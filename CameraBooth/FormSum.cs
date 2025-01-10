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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace CameraBooth
{
    public partial class FormSum : Form
    {
        public FormSum()
        {
            InitializeComponent();
        }

        ConfigManager configManager = new ConfigManager("../../config.config");

        private void FormSum_Load(object sender, EventArgs e)
        {
            // กำหนดไฟล์ภาพ
            string backgroundPath = configManager.Get("PathBackground");
            string effectsPath = configManager.Get("PathEffect");
            string[] images = Directory.GetFiles(configManager.Get("PathOutputImage"), "*.jpg");

            // ขนาดของภาพสุดท้าย (เช่นเดียวกับ background)
            int finalWidth = 1080;   // ความกว้างของ background
            int finalHeight = 1920; // ความสูงของ background

            // สร้าง Bitmap สำหรับภาพรวมทั้งหมด
            using (Bitmap finalImage = new Bitmap(finalWidth, finalHeight))
            {
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    // วาด background
                    using (Image background = Image.FromFile(backgroundPath))
                    {
                        g.DrawImage(background, 0, 0, finalWidth, finalHeight);
                    }

                    // ขนาดของแต่ละภาพ (1:1)
                    int imageSize = finalWidth / 3; // กำหนดให้ภาพมีขนาด 1/4 ของความกว้าง background
                    int spacing = imageSize / 10;    // ระยะห่างระหว่างภาพ

                    // วาดภาพ 1-6 (2 คอลัมน์, 3 แถว)
                    for (int i = 0; i < images.Length; i++)
                    {
                        using (Image img = Image.FromFile(images[i]))
                        {
                            int column = i % 2; // คอลัมน์ (0 หรือ 1)
                            int row = i / 2;    // แถว (0, 1, 2)

                            // คำนวณตำแหน่ง x, y
                            int x = spacing + column * (imageSize + spacing);
                            int y = spacing + row * (imageSize + spacing);

                            // วาดภาพ
                            g.DrawImage(img, x, y, imageSize, imageSize);
                        }
                    }

                    // วาด effects ด้านบนสุด
                    using (Image effects = Image.FromFile(effectsPath))
                    {
                        g.DrawImage(effects, 0, 0, finalWidth, finalHeight);
                    }
                }

                // บันทึกภาพสุดท้าย
                string pathFolder = configManager.Get("PathOutputImage") + "/sum";
                if (!Directory.Exists(pathFolder))
                {
                    Directory.CreateDirectory(pathFolder);
                }
                string outputPath = pathFolder + "/combined_image.jpg";
                finalImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                using (var stream = new MemoryStream(File.ReadAllBytes(outputPath)))
                {
                    pbSum.Image = Image.FromStream(stream);
                }
            }
        }
    }
}
