using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MainDesing
{
    public partial class Main : Form
    {
        //設定SHADOW
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        public Main()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            this.Userbar.Width = 0;
        }

        private void MyClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool IfMdown = false;
        int NowX, NowY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IfMdown = true;
            NowX = e.X;
            NowY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IfMdown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Nvabar.Left = ((Button)sender).Left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Nvabar.Left = ((Button)sender).Left;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Nvabar.Left = ((Button)sender).Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Nvabar.Left = ((Button)sender).Left;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IfMdown)
            {
                this.Location = new Point(this.Left += e.X - NowX, this.Top += e.Y - NowY);
            }
        }
        bool userCheck = false;
        private void button6_Click(object sender, EventArgs e)
        {
            userCheck = !userCheck;
            this.timer1.Start();
            this.timer1.Tick += delegate
             {
                 if (userCheck)
                 {
                     if (this.Userbar.Width != 150)
                     {
                         this.Userbar.Width += 10;
                     }
                     else
                     {
                         this.timer1.Stop();
                         this.timer1.Dispose();
                     }
                 }
                 else
                 {
                     if (this.Userbar.Width != 0)
                     {
                         this.Userbar.Width -= 10;
                     }
                     else
                     {
                         this.timer1.Stop();
                         this.timer1.Dispose();
                     }
                 }
             };
        }





        //private void resizeBottom()
        //{
        //    this.SetBounds(0, 0, SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
        //}
        //protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        //{
        //    base.SetBoundsCore(x, y, width, height, specified);
        //    Update();
        //}
        //void barAnimation(object sender)
        //    {
        //        Timer tim = new Timer();
        //        tim.Tick += delegate
        //        {
        //            if (this.Nvabar.Left > ((Button)sender).Left)
        //            {
        //                tim.Start();
        //                this.Nvabar.Left -= 1;
        //            }
        //            else
        //            {
        //                this.Nvabar.Left = ((Button)sender).Left;
        //                tim.Stop();
        //            }

        //        };
        //        tim.Start();
        //    }
        //}
    }
}
