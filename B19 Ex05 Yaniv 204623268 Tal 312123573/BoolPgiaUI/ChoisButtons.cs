using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    public partial class ChoisButtons : UserControl
    {
        private PickColorForm m_PickColorForm = new PickColorForm();
        internal List<Color> m_ChosenColors = new List<Color>();

        public ChoisButtons()
        {
            InitializeComponent();
        }

        internal void EnableButtons()
        {
            ChoiseButton1.Enabled = true;
            ChoiseButton2.Enabled = true;
            ChoiseButton3.Enabled = true;
            ChoiseButton4.Enabled = true;
        }
        
        internal void UnEnableButtons()
        {
            foreach (Button button in Controls)
            {
                button.Enabled = false;
            }
        }

        private void choiseButtonOnClick(object sender, EventArgs e)
        {
            Button choisedButton = sender as Button;
            m_PickColorForm.SetColor(choisedButton);
            if (isAllButtonsSlected())
            {
                CheckResButton.Enabled = true;
            }
        }

        private bool isAllButtonsSlected()
        {
            bool isAllButtonsSelected = false;

            if (PickColorForm.ColorToChar.ContainsKey(ChoiseButton1.BackColor) &&
                PickColorForm.ColorToChar.ContainsKey(ChoiseButton2.BackColor) &&
                PickColorForm.ColorToChar.ContainsKey(ChoiseButton3.BackColor) &&
                PickColorForm.ColorToChar.ContainsKey(ChoiseButton4.BackColor))
            {
                isAllButtonsSelected = true;
            }

            return isAllButtonsSelected;
        }

        private void checkResButtonOnClick(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
            m_ChosenColors = new List<Color>();
            m_ChosenColors.Add(ChoiseButton1.BackColor);
            m_ChosenColors.Add(ChoiseButton2.BackColor);
            m_ChosenColors.Add(ChoiseButton3.BackColor);
            m_ChosenColors.Add(ChoiseButton4.BackColor);
            (ParentForm as GameForm).CheckResults(m_ChosenColors);
        }
    }
}
