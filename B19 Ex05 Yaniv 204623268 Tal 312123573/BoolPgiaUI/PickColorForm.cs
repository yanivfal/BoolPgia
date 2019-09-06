using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    public partial class PickColorForm : Form
    {
        private Button m_ButtonToChange;
        private static readonly Dictionary<Color, char> sr_ColorToChar = new Dictionary<Color, char>();
        internal static Dictionary<Color, char> ColorToChar
        {
            get
            {
                return sr_ColorToChar;
            }
        }

        public PickColorForm()
        {    
            InitializeComponent();
            initializeDictionary();
        }

        internal void SetColor(Button i_ButtonToChange)
        {
            m_ButtonToChange = i_ButtonToChange;
            this.ShowDialog();
        }

        private void buttonOnClick(object sender, EventArgs e)
        {
            Button colorButton = sender as Button;
            m_ButtonToChange.BackColor = colorButton.BackColor;
            this.Visible = false;
        }

        private void initializeDictionary()
        {
            char charToMap = 'A';

            foreach (Button button in Controls)
            {
                sr_ColorToChar[button.BackColor] = charToMap;
                charToMap++;
            }
        }

        internal static string ConvertColorListToString(List<Color> i_ColorList)
        {
            StringBuilder resultsSB = new StringBuilder();

            foreach (Color color in i_ColorList)
            {
                resultsSB.Append(sr_ColorToChar[color]);
            }

            return resultsSB.ToString();     
        }
    }
}
