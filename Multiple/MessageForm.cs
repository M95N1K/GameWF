using System;
using System.Windows.Forms;

namespace Multiple
{
    public partial class MessageForm : Form
    {
        public int Targ
        {
            set
            {
                Targets.Text = string.Format("{0}", value);
            }
        }

        public MessageForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
