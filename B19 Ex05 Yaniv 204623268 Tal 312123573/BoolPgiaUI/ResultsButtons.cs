using System.Drawing;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    public partial class ResultsButtons : UserControl
    {
        public ResultsButtons()
        {
            InitializeComponent();
        }

        internal void FillUpResualtsButtons(int i_NumberOfBool, int i_NumberOfPgia)
        {
            int index = 3;

            for (int i = 0; i < i_NumberOfBool; i++)
            {
                Controls[index].BackColor = Color.Black;
                index--;
            }

            for (int i = 0; i < i_NumberOfPgia; i++)
            {
                Controls[index].BackColor = Color.Yellow;
                index--;
            }
        }
    }  
}
