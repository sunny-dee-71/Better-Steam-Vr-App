using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Steam_Vr
{
    public partial class Better_Steam: Form
    {
        public static string steamPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR";
        public static bool Patched = false;
        public static Better_Steam instance;
        private Better_Steam_Patcher better_Steam_Patcher;

        public Better_Steam()
        {
            instance = this;
            CheckSteamVRPath();
            if (Directory.Exists(steamPath))
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Finding Steam VR Failed");
                Environment.Exit(0);
                return;
            }
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
            instance.Visible = true;

            if (Directory.Exists(steamPath + "\\Better_Steam_Vr"))
            {
                Patched = true;
            }
            FixButtons();
            if (!Patched)
            {
                if (better_Steam_Patcher == null)
                {
                    better_Steam_Patcher = new Better_Steam_Patcher();
                    better_Steam_Patcher.TopLevel = false;
                    better_Steam_Patcher.FormBorderStyle = FormBorderStyle.None;
                    better_Steam_Patcher.Dock = DockStyle.Fill; 
                    instance.Controls.Add(better_Steam_Patcher);
                    better_Steam_Patcher.Show(); 
                }
                else
                {
                    better_Steam_Patcher.Show();
                }
                instance.Visible = false; 
            }
            else
            {
                instance.Visible = true;
            }
        }

        public void FixButtons()
        {
            guna2Button1.Visible = Patched;
            guna2Button2.Visible = Patched;
            guna2Button3.Visible = Patched;
            guna2Button4.Visible = Patched;
            guna2Button5.Visible = Patched;
            label1.Visible = Patched;
        }





        private void CheckSteamVRPath()
        {
            if (!Directory.Exists(steamPath) || !IsSteamVRDirectory(steamPath))
            {
                MessageBox.Show("SteamVR not found. Please locate your SteamVR path and continue.");

                bool pathIsValid = false;

                while (!pathIsValid)
                {
                    using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                    {
                        folderDialog.Description = "Select the SteamVR directory";
                        folderDialog.SelectedPath = @"C:\";

                        DialogResult result = folderDialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            steamPath = folderDialog.SelectedPath;

                            if (IsSteamVRDirectory(steamPath))
                            {
                                MessageBox.Show($"SteamVR path set to: {steamPath}");
                                pathIsValid = true;
                            }
                            else
                            {
                                MessageBox.Show("The selected folder is not a valid SteamVR directory. Please select the correct SteamVR path.");
                            }
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            pathIsValid = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"SteamVR found at: {steamPath}");
            }
        }


        private bool IsSteamVRDirectory(string path)
        {
            string steamVRFile = Path.Combine(path, "steamvr.vrmanifest");
            string driversFolder = Path.Combine(path, "drivers");
            string binFolder = Path.Combine(path, "bin");

            return File.Exists(steamVRFile) || Directory.Exists(driversFolder) || Directory.Exists(binFolder);
        }

        private void General_Tab_Click(object sender, EventArgs e)
        {
            
        }

        private void Texturers_Tab_Click(object sender, EventArgs e)
        {
            
        }

        private void HAB()
        {
            if (BSG != null)
            {
                BSG.Hide();
            }
            if (BST != null)
            {
                BST.Hide();
            }
            if (BSTH != null)
            {
                BSTH.Hide();
            }
            if (BSS != null)
            {
                BSS.Hide();
            }
            if (BSM != null)
            {
                BSM.Hide();
            }
            if (BSSP != null)
            {
                BSSP.Hide();
            }
            if (BSI != null)
            {
                BSI.Hide();
            }
            instance.Visible = true;
        }


        public Better_Steam_Vr.Tabs.Settings BSG;
        public Better_Steam_Texturers BST;
        public Better_Steam_Vr.Tabs.Themes BSTH;
        public Better_Steam_Vr.Tabs.Sounds BSS;
        public Better_Steam_Vr.Tabs.Models BSM;
        public Better_Steam_Vr.Tabs.Spoofer BSSP;
        public Better_Steam_Vr.Tabs.Icons BSI;

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HAB();
            if (BSG == null)
            {
                BSG = new Better_Steam_Vr.Tabs.Settings();
                BSG.TopLevel = false;
                BSG.FormBorderStyle = FormBorderStyle.None;
                BSG.Dock = DockStyle.Fill;
                instance.Controls.Add(BSG);
                BSG.Show();
            }
            else
            {
                BSG.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HAB();
            if (BST == null)
            {
                BST = new Better_Steam_Texturers();
                BST.TopLevel = false;
                BST.FormBorderStyle = FormBorderStyle.None;
                BST.Dock = DockStyle.Fill;
                instance.Controls.Add(BST);
                BST.Show();
            }
            else
            {
                BST.Show();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            HAB();
            if (BSTH == null)
            {
                BSTH = new Better_Steam_Vr.Tabs.Themes();
                BSTH.TopLevel = false;
                BSTH.FormBorderStyle = FormBorderStyle.None;
                BSTH.Dock = DockStyle.Fill;
                instance.Controls.Add(BSTH);
                BSTH.Show();
            }
            else
            {
                BSTH.Show();
            }
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            HAB();
            if (BSS == null)
            {
                BSS = new Better_Steam_Vr.Tabs.Sounds();
                BSS.TopLevel = false;
                BSS.FormBorderStyle = FormBorderStyle.None;
                BSS.Dock = DockStyle.Fill;
                instance.Controls.Add(BSS);
                BSS.Show();
            }
            else
            {
                BSS.Show();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            HAB();
            if (BSM == null)
            {
                BSM = new Better_Steam_Vr.Tabs.Models();
                BSM.TopLevel = false;
                BSM.FormBorderStyle = FormBorderStyle.None;
                BSM.Dock = DockStyle.Fill;
                instance.Controls.Add(BSM);
                BSM.Show();
            }
            else
            {
                BSM.Show();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/sunny-dee-71/better-steam-vr",
                UseShellExecute = true
            });

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            HAB();
            if (BSSP == null)
            {
                BSSP = new Better_Steam_Vr.Tabs.Spoofer();
                BSSP.TopLevel = false;
                BSSP.FormBorderStyle = FormBorderStyle.None;
                BSSP.Dock = DockStyle.Fill;
                instance.Controls.Add(BSSP);
                BSSP.Show();
            }
            else
            {
                BSSP.Show();
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            HAB();
            if (BSI == null)
            {
                BSI = new Better_Steam_Vr.Tabs.Icons();
                BSI.TopLevel = false;
                BSI.FormBorderStyle = FormBorderStyle.None;
                BSI.Dock = DockStyle.Fill;
                instance.Controls.Add(BSI);
                BSI.Show();
            }
            else
            {
                BSI.Show();
            }
        }
    }
}
