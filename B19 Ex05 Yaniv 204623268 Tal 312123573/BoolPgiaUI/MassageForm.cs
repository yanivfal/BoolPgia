using System;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    public partial class MassageForm : Form
    {
        public MassageForm(string i_MassageToShow)
        {
            InitializeComponent();
            Massage.Text = i_MassageToShow;
        }

        private void buttonOKOnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
