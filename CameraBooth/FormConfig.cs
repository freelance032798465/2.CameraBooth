using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraBooth
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        ConfigManager configManager = new ConfigManager("../../config.config");



        private void FormConfig_Load(object sender, EventArgs e)
        {
            using (var stream = new MemoryStream(File.ReadAllBytes(configManager.Get("PathBackground"))))
            {
                pbBackground.Image = Image.FromStream(stream);
            }
            using (var stream = new MemoryStream(File.ReadAllBytes(configManager.Get("PathEffect"))))
            {
                pbEffect.Image = Image.FromStream(stream);
            }
        }




        private void btBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetFullPath(@"../../resource/background/");
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    using (var stream = new MemoryStream(File.ReadAllBytes(selectedFilePath)))
                    {
                        pbBackground.Image = Image.FromStream(stream);
                    }
                    configManager.Set("PathBackground", openFileDialog.FileName);
                    configManager.SaveConfig();
                }
            }
        }

        private void btEffect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetFullPath(@"../../resource/effect/");
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    using (var stream = new MemoryStream(File.ReadAllBytes(selectedFilePath)))
                    {
                        pbEffect.Image = Image.FromStream(stream);
                    }
                    configManager.Set("PathEffect", openFileDialog.FileName);
                    configManager.SaveConfig();
                }
            }
        }
    }
}
