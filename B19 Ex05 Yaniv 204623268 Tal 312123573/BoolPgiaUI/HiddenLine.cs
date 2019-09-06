using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace BoolPgiaUI
{
    public partial class HiddenLine : UserControl
    {
        public HiddenLine()
        {
            InitializeComponent();
        }

        internal void RevealSolution(string i_Solution)
        {
            Dictionary<Color, char> colorToChar = PickColorForm.ColorToChar;
            int index = 3;

            foreach (char c in i_Solution)
            {
                foreach (Color color in colorToChar.Keys)
                {
                    if (colorToChar[color] == c)
                    {
                        Controls[index].BackColor = color;
                        index--;
                    }
                }
            }
        }
    }
}
