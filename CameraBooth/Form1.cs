using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text;

namespace CameraBooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient client;
        private NetworkStream stream;
        private Timer tmSteam;
        private Timer tmCountdown;
        private Timer tmWaitImagePython;
        ConfigManager configManager = new ConfigManager("../../config.config");
        private int countdownValue;
        private string serverAddress;
        private int port;
        private int score = 0;
        private string destinationDirectory;
        private string sourceFilePath = @"../../pythonCamera/captured_image.jpg";
        private string destinationFilePath;

        private void Form1_Load(object sender, EventArgs e)
        {
            serverAddress = configManager.Get("Server");
            port = Convert.ToInt32(configManager.Get("Port"));
            destinationDirectory = configManager.Get("PathOutputImage");

            try
            {
                client = new TcpClient(serverAddress, port);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }

            tmSteam = new Timer();
            tmSteam.Interval = 50;
            tmSteam.Tick += tmSteam_Tick;
            tmSteam.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sendCommand("exit");
        }







        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Visible = false;
            try
            {
                tmCountdown.Dispose();
            }
            catch { }

            tmCountdown = new Timer();
            tmCountdown.Interval = 1000;
            tmCountdown.Tick += tmCountdown_Tick;

            countdownValue = 3;
            lbStartCapture.Text = countdownValue.ToString();
            lbStartCapture.Visible = true;
            tmCountdown.Start();
        }
        private void btContinue_Click(object sender, EventArgs e)
        {
            if (score == 6)
            {
                this.Hide();
                FormSum FormSum = new FormSum();
                FormSum.ShowDialog();
                this.Show();
                this.Close();
                return;
            }

            btContinue.Visible = false;
            btStart.Visible = true;
            btDelete.Visible = false;
            tmSteam.Start();
        }
        private void btBackgroundLeft_Click(object sender, EventArgs e)
        {
            sendCommand("background2");
        }
        private void btBackgroundRight_Click(object sender, EventArgs e)
        {
            sendCommand("background3");
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            btContinue.Visible = false;
            btStart.Visible = true;
            btDelete.Visible = false;
            File.Delete(destinationFilePath);
            score--;
            lbScore.Text = $"{score}/6";
            tmSteam.Start();
        }
        private void btConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConfig FormConfig = new FormConfig();
            FormConfig.ShowDialog();
            this.Show();
        }







        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (client != null && client.Connected)
            {
                stream.Close();
                client.Close();
            }
        }






        private void tmSteam_Tick(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                string message = "getFrame";
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                byte[] sizeInfo = new byte[4];
                while (true)
                {
                    int bytesRead = stream.Read(sizeInfo, 0, sizeInfo.Length);
                    if (bytesRead == 0)
                        break;

                    int dataSize = BitConverter.ToInt32(sizeInfo, 0);
                    byte[] data2 = new byte[dataSize];
                    int totalBytesRead = 0;
                    while (totalBytesRead < dataSize)
                    {
                        bytesRead = stream.Read(data2, totalBytesRead, dataSize - totalBytesRead);
                        totalBytesRead += bytesRead;
                    }

                    using (MemoryStream ms = new MemoryStream(data2))
                    {
                        Image image = Image.FromStream(ms);
                        pbImage.Image = image;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Client is not connected to server!");
            }
        }
        private void tmWaitImagePython_Tick(object sender, EventArgs e)
        {
            if (File.Exists(sourceFilePath))
            {
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = "image_" + timestamp + ".jpg";
                destinationFilePath = Path.Combine(destinationDirectory, fileName);
                try
                {
                    File.Move(sourceFilePath, destinationFilePath);
                    tmWaitImagePython.Stop();
                    tmSteam.Stop();
                    using (var stream = new MemoryStream(File.ReadAllBytes(destinationFilePath)))
                    {
                        pbImage.Image = Image.FromStream(stream);
                    }
                    processAfterCapture();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while moving the file: " + ex.Message);
                }
            }
        }
        private void tmCountdown_Tick(object sender, EventArgs e)
        {
            countdownValue--;
            lbStartCapture.Text = countdownValue.ToString();

            if (countdownValue == 0)
            {
                tmCountdown.Stop();
                lbStartCapture.Visible = false;

                if (client != null && client.Connected)
                {
                    string message = "capture";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    data = new byte[1024];
                    int bytes = stream.Read(data, 0, data.Length);
                    string response = Encoding.UTF8.GetString(data, 0, bytes);

                    tmWaitImagePython = new Timer();
                    tmWaitImagePython.Interval = 200;
                    tmWaitImagePython.Tick += tmWaitImagePython_Tick;
                    tmWaitImagePython.Start();
                }
                else
                {
                    MessageBox.Show("Client is not connected to server!");
                }
            }
        }





        private string sendCommand(string message)
        {
            if (client != null && client.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                data = new byte[1024];
                int bytes = stream.Read(data, 0, data.Length);
                return Encoding.UTF8.GetString(data, 0, bytes);
            }
            else
            {
                MessageBox.Show("Client is not connected to server!");
                return "Client is not connected to server!";
            }
        }
        private void processAfterCapture()
        {
            btContinue.Visible = true;
            btDelete.Visible = true;
            score++;
            lbScore.Text = $"{score}/6";
        }
    }
}
