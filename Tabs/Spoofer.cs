using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Steam_Vr.Tabs
{
    public partial class Spoofer : Form
    {
        private string steamVrPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR";
        public async Task THing(string fileUrl, string filePath)
        {
            if (string.IsNullOrWhiteSpace(fileUrl))
            {
                MessageBox.Show("Error: URL is empty!");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Console.WriteLine($"Downloading from: {fileUrl}");

                    byte[] imageData = await client.GetByteArrayAsync(fileUrl);

                    string directory = Path.GetDirectoryName(filePath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    File.WriteAllBytes(filePath, imageData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        public Spoofer()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string Url = "";
            string Url2 = "";
            string Url3 = "";
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/quest_headset_ready.b4bfb144.png";
                    Url2 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/rifts_left_controller_ready.b4bfb144.png";
                    Url3 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/rifts_right_controller_ready.b4bfb144.png";
                    break;
                case 1:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1H.png";
                    Url2 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1L.png";
                    Url3 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1R.png";
                    break;
                case 2:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/questH.png";
                    Url2 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/questL.png";
                    Url3 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/questR.png";
                    break;
                default:
                    MessageBox.Show("Invalid selection!");
                    return;
            }
            await THing(Url, steamVrPath + @"\drivers\oculus\resources\icons\quest_headset_ready.b4bfb144.png");
            await THing(Url2, steamVrPath + @"\drivers\oculus\resources\icons\rifts_left_controller_ready.b4bfb144.png");
            await THing(Url3, steamVrPath + @"\drivers\oculus\resources\icons\rifts_right_controller_ready.b4bfb144.png");
            MessageBox.Show("Spoofing Saved!");
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            string Url = "";
            string Url2 = "";
            string Url3 = "";
            switch (guna2ComboBox2.SelectedIndex)
            {
                case 0:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1_headset_ready.b4bfb144.png";
                    Url2 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1_left_controller_ready.b4bfb144.png";
                    Url3 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1_right_controller_ready.b4bfb144.png";
                    break;
                case 1:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1H.png";
                    Url2 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1L.png";
                    Url3 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/cv1R.png";
                    break;
                case 2:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/questH.png";
                    Url2 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/questL.png";
                    Url3 = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Spoofers/questR.png";
                    break;
                default:
                    MessageBox.Show("Invalid selection!");
                    return;
            }
            await THing(Url, steamVrPath + @"\drivers\oculus\resources\icons\cv1_headset_ready.b4bfb144.png");
            await THing(Url2, steamVrPath + @"\drivers\oculus\resources\icons\cv1_left_controller_ready.b4bfb144.png");
            await THing(Url3, steamVrPath + @"\drivers\oculus\resources\icons\cv1_right_controller_ready.b4bfb144.png");
            MessageBox.Show("Spoofing Saved!");
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
