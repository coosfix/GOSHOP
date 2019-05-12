using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public  string 輸入塊字串
        {
            get
            {
                return this.Textbox_text.Text;
            }
        }


        private void Account_text_Leave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Gray;
            this.panel3.Height -= 2;
        }

        private void Account_text_Enter(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(139, 124, 100);
            this.panel3.Height += 2;
        }
    }
}
