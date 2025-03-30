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
    public partial class Themes : Form
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
        public Themes()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string Url = "";
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Themes/Normal.css";
                    break;
                case 1:
                    Url = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Themes/FysShittyTheme.css";
                    break;
                default:
                    MessageBox.Show("Invalid selection!");
                    return;
            }
            await THing(Url, steamVrPath + @"\resources\webinterface\dashboard\css\base.css");
            MessageBox.Show("Theme Saved!");
        }
    }
}
