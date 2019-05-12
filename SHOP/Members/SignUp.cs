using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Members
{
    public partial class SignUp : desingner
    {
        public SignUp()
        {
            InitializeComponent();
            this.Gender.SelectedIndex = 0;
            this.City.SelectedIndex = 0;
            this.RegionId.SelectedIndex = 0;
        }

        private void SignIN_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInAndForgotPW newform = new SignInAndForgotPW();
            newform.ShowDialog();
            this.Close();
        }
    }
}
