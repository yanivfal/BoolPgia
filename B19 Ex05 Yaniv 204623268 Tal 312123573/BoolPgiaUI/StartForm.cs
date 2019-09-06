using System;
using System.Windows.Forms;
using BoolPgiaLogic;

namespace BoolPgiaUI
{
    public partial class StartForm : Form
    {
        private int m_NumOfChoices;
        private readonly int r_MaxChoise = GameManager.MaxNumOfGuesses;
        private readonly int r_MinChoise = GameManager.MinNumOfGuesses;

        public StartForm()
        {
            m_NumOfChoices = r_MinChoise;
            InitializeComponent();
            buttonNumOfChoise.Text = string.Format("Number of chances: {0}", m_NumOfChoices);
        }

        private void buttonStartOnClick(object sender, EventArgs e)
        {
            this.Visible = false;
            new GameForm(m_NumOfChoices).ShowDialog();
        }

        private void buttonNumOfChoiseOnClick(object sender, EventArgs e)
        {
            m_NumOfChoices++;
            if (m_NumOfChoices > r_MaxChoise)
            {
                m_NumOfChoices = r_MinChoise;
            }

            buttonNumOfChoise.Text = string.Format("Number of chances: {0}", m_NumOfChoices);
        }
    }
}
