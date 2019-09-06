using System;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void buttonYesOnClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonNoOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
