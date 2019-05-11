using MainDesing;
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


namespace Members
{
    public partial class SignIn : desingner
    {

        public SignIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void Pwordtext_Enter(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(139, 124, 100);
            this.panel4.Height += 2;
        }

        private void Pwordtext_Leave(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Gray;
            this.panel4.Height -= 2;
        }

        private void Usertext_Enter(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(139, 124, 100);
            this.panel3.Height += 2;
        }

        private void Usertext_Leave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Gray;
            this.panel3.Height -= 2;
        }
    }
}
