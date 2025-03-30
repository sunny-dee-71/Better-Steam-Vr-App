using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Steam_Vr
{
    public partial class Better_Steam_Texturers: Form
    {
        private string steamVrPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR";
        public Better_Steam_Texturers()
        {
            InitializeComponent();
            steamVrPath = Better_Steam.steamPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private async void Save_Custom_Cons_Click(object sender, EventArgs e)
        {
            
        }

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

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Text = "Loading Texture...";
            string leftUrl = "", rightUrl = "";

            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    leftUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/orignal%20left%20quest%203.png";
                    rightUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/orignal%20right%20quest%203.png";
                    break;
                case 1:
                    leftUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/orignal%20left%20quest%202.png";
                    rightUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/orignal%20right%20quest%202.png";
                    break;
                case 2:
                    leftUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/quest%203%20femboy%20left.png";
                    rightUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/quest%203%20femboy%20right.png";
                    break;
                case 3:
                    leftUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/quest%202%20femboy%20left.png";
                    rightUrl = "https://raw.githubusercontent.com/sunny-dee-71/better-steam-vr/main/Textures/quest%202%20femboy%20right.png";
                    break;
                default:
                    guna2Button1.Text = "Load Texture";
                    MessageBox.Show("Invalid selection!");
                    return;
            }

            string leftPath, rightPath;

            if (guna2ComboBox1.SelectedIndex == 0 || guna2ComboBox1.SelectedIndex == 2)
            {
                leftPath = steamVrPath + @"\resources\rendermodels\oculus_quest_plus_controller_left\oculus_quest_plus_controller_left_color.png";
                rightPath = steamVrPath + @"\resources\rendermodels\oculus_quest_plus_controller_right\oculus_quest_plus_controller_right_color.png";
            }
            else
            {
                leftPath = steamVrPath + @"\resources\rendermodels\oculus_quest2_controller_left\oculus_quest2_controller_left.png";
                rightPath = steamVrPath + @"\resources\rendermodels\oculus_quest2_controller_right\oculus_quest2_controller_right.png";
            }

            await THing(leftUrl, leftPath);
            await THing(rightUrl, rightPath);

            guna2Button1.Text = "Load Texture";
            MessageBox.Show("Textures Saved!");
        }
    }
}
