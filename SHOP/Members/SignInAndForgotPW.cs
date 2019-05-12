using MainDesing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Members
{
    public partial class SignInAndForgotPW : desingner
    {

        public SignInAndForgotPW()
        {
            InitializeComponent();
        }

        private void SignIN_B_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Account.輸入塊字串}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timer tim = new Timer();

            tim.Interval = 10;
            this.panel4.Visible = !this.panel4.Visible;
            tim.Tick += delegate
            {
                this.panel3.Left -= 50;
                if (this.panel3.Left == 0)
                {
                    tim.Stop();
                    this.panel4.Visible = !this.panel4.Visible;
                }
            };
            tim.Start();
        }

        private void GoLogIn_Click(object sender, EventArgs e)
        {
            Timer tim = new Timer();

            tim.Interval = 10;
            this.panel4.Visible = !this.panel4.Visible;
            tim.Tick += delegate
            {
                this.panel3.Left += 50;
                if (this.panel3.Left == 500)
                {
                    tim.Stop();
                    this.panel4.Visible = !this.panel4.Visible;
                }
            };
            tim.Start();
        }
    }
}
