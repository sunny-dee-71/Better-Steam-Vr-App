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
    public partial class Better_Steam_Patcher: Form
    {
        public static bool Patched = false;
        private string steamPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR";
        public Better_Steam_Patcher()
        {
            InitializeComponent();
            steamPath = Better_Steam.steamPath;
            SetPatched();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetPatched()
        {
            if(Directory.Exists(steamPath + "\\Better_Steam_Vr"))
            {
                Patched = true;
            }
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            if (!Patched)
            {
                guna2Button1.Visible = true;
                PatchingBar.Visible = true;
                label1.Visible = true;
            }
            else
            {
                guna2Button1.Visible = false;
                PatchingBar.Visible = false;
                label1.Visible = false;
                Better_Steam.instance.Show();
                Better_Steam.instance.SetPatched();
                //this.Close();

            }
        }

        public async Task THing(string fileUrl, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    byte[] imageData = await client.GetByteArrayAsync(fileUrl);

                    File.WriteAllBytes(filePath, imageData);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }


        public async void _Patch()
        {
            guna2Button1.Text = "Patching...";
            PatchingBar.Value = 1;
            Directory.CreateDirectory(steamPath + "\\Better_Steam_Vr");
            await Task.Delay(800); 

            PatchingBar.Value = 2;
            string fileUrl = "https://github.com/sunny-dee-71/better-steam-vr/blob/main/images/app_icon.png?raw=true";
            await Task.Delay(1200);

            string filePath = steamPath + "\\content\\vrmonitor\\icons\\app_icon.png";
            PatchingBar.Value = 3;
            await Task.Delay(1500);  

            await THing(fileUrl, filePath);
            PatchingBar.Value = 4;
            await Task.Delay(2000); 

            PatchingBar.Value = 5;
            await Task.Delay(1000);

            guna2Button1.Text = "Patched.";

            await Task.Delay(1000);
            MessageBox.Show("Error Please Restart The App");

            SetPatched();
            UpdateButtonStates();
        }

        private void PatchingBar_Click(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _Patch();
        }

        private void Patch_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            _Patch();
        }
    }
}
