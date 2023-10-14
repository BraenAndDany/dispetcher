using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;
using System.IO;

namespace dispetcher
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string sdoDIsk;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
                    DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            Console.WriteLine("Drive {0}", d.Name);
            Console.WriteLine("  Drive type: {0}", d.DriveType);
            if (d.IsReady == true)
            {
                Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                Console.WriteLine("  File system: {0}", d.DriveFormat);
                Console.WriteLine(
                    "  Available space to current user:{0, 15} bytes",
                    d.AvailableFreeSpace);

                Console.WriteLine(
                    "  Total available space:          {0, 15} bytes",
                    d.TotalFreeSpace);

                Console.WriteLine(
                    "  Total size of drive:            {0, 15} bytes ",
                    d.TotalSize);
            }
        }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float fbram = pRAMBytes.NextValue();
            //Set value to cpu and ram
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            //Update value to cpu and ram label
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            lblRAMBytes.Text = string.Format("{0:0}", fbram/1048576);
            //Draw cpu and ram chart
        }
        public static class ConverterExtension
        {
            private const long Kb = 1024;
            private const long Mb = Kb * 1024;
            private const long Gb = Mb * 1024;
            private const long Tb = Gb * 1024;


        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblRAMBytes_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
