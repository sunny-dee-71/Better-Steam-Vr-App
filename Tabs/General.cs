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
    public partial class Better_Steam_General: Form
    {
        public static bool Patched = false;
        private string steamVrPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR";
        public Better_Steam_General()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Preds_AMount.Text = trackBar1.Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Save_Preds_Click(object sender, EventArgs e)
        {
            string initialPath = steamVrPath;
            string steamPath = GetSteamPath(initialPath);

            if (steamPath == null)
            {
                MessageBox.Show("Steam directory not found!");
                return;
            }

            string vrSettingsPath = Path.Combine(steamPath, @"config\steamvr.vrsettings");

            if (!File.Exists(vrSettingsPath))
            {
                MessageBox.Show("steamvr.vrsettings file not found at: " + vrSettingsPath);
                return;
            }

            try
            {
                string json = File.ReadAllText(vrSettingsPath);
                JObject config = JObject.Parse(json);

                float motionPrediction = Math.Min(trackBar1.Value, 500) / 1000f;

                config["steamvr"]["motionPrediction"] = motionPrediction;

                File.WriteAllText(vrSettingsPath, config.ToString());

                MessageBox.Show("Succesfully Set Preds Amount");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private string GetSteamPath(string currentPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(currentPath);

            while (dirInfo.Parent != null)
            {
                if (dirInfo.Name.Equals("Steam", StringComparison.OrdinalIgnoreCase))
                {
                    return dirInfo.FullName;
                }

                dirInfo = dirInfo.Parent;
            }

            return null;
        }

    }
}
