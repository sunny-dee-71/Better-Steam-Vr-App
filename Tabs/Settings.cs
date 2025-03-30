using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Steam_Vr.Tabs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Program Files (x86)\Steam\config\steamvr.vrsettings");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("\"steam.app.1533390\"") && lines[i + 1].Contains("\"worldScale\""))
                {
                    lines[i + 1] = "      \"worldScale\": 2,"; // Update to desired value
                    break;
                }
            }
            File.WriteAllLines(@"C:\Program Files (x86)\Steam\config\steamvr.vrsettings", lines);

        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
