using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BoolPgiaLogic;

namespace BoolPgiaUI
{
    public partial class GameForm : Form
    {
        private HiddenLine m_HiddenLine = new HiddenLine();
        private static ChoisButtons[] s_ChoiseButtons;
        private static ResultsButtons[] s_ResultsButtons;
        private GameManager m_Game;
        private const int k_SpaceBetweenLines = 5;

        public GameForm(int i_NumOfChoise)
        {
            m_Game = new GameManager(i_NumOfChoise);
            s_ChoiseButtons = new ChoisButtons[i_NumOfChoise];
            s_ResultsButtons = new ResultsButtons[i_NumOfChoise];
            InitializeComponent();
        }

        private void GameFormLoad(object sender, EventArgs e)
        {
            int lineHight;
            ChoisButtons choiseButtonsLine;
            ResultsButtons resButtons;

            m_HiddenLine.Location = new Point(10, 10);
            lineHight = m_HiddenLine.Bottom + 20;
            for (int i = 0; i < s_ChoiseButtons.Length; i++)
            {
                choiseButtonsLine = new ChoisButtons();
                resButtons = new ResultsButtons();
                choiseButtonsLine.Location = new Point(m_HiddenLine.Left, lineHight);
                resButtons.Location = new Point(choiseButtonsLine.Right + 5, lineHight);
                s_ChoiseButtons[i] = choiseButtonsLine;
                s_ResultsButtons[i] = resButtons;
                lineHight += choiseButtonsLine.Height + k_SpaceBetweenLines;
            }

            s_ChoiseButtons[0].EnableButtons();
            this.Height = s_ChoiseButtons.Length * (new ChoisButtons().Height + k_SpaceBetweenLines) + 110;
            this.Width = new ChoisButtons().Width + new ResultsButtons().Width + 40;

            this.Controls.Add(m_HiddenLine);
            this.Controls.AddRange(s_ChoiseButtons);
            this.Controls.AddRange(s_ResultsButtons);
        }

        internal void NextGuess()
        {
            m_Game.CurrentNumOfSteps++;
            if (m_Game.IsPlayerWon || m_Game.IsPlayerLost)
            {
                finishGame();
            }
            else
            {
                s_ChoiseButtons[m_Game.CurrentNumOfSteps - 1].UnEnableButtons();
                s_ChoiseButtons[m_Game.CurrentNumOfSteps].EnableButtons();
            }
        }

        internal void CheckResults(List<Color> i_ChosenColors)
        {
            int o_NumberOfBool;
            int o_NumberOfPgia;
            string userChoiseStr = PickColorForm.ConvertColorListToString(i_ChosenColors);
            bool isValidGuess = true;

            isValidGuess = m_Game.GetResults(userChoiseStr, out o_NumberOfBool, out o_NumberOfPgia);
            if (!isValidGuess)
            {       
                new MassageForm("Invalid Guess! you need to choose 4 differents colors!").ShowDialog();
            }
            else
            {
                s_ResultsButtons[m_Game.CurrentNumOfSteps].FillUpResualtsButtons(o_NumberOfBool, o_NumberOfPgia);
                NextGuess();
            }
        }

        private void finishGame()
        {
            string massageToUser;

            if (m_Game.IsPlayerWon)
            {
                massageToUser = string.Format("You win after {0} steps!{1}Do you want to play again?",
                m_Game.CurrentNumOfSteps, Environment.NewLine);
            }
            else
            {
                massageToUser = string.Format("You Lost!{0}Do you want to play again?",
                Environment.NewLine);
            }

            m_HiddenLine.RevealSolution(m_Game.Solution);
            ExitForm exitform = new ExitForm();
            exitform.Massage.Text = massageToUser;
            exitform.ShowDialog();
        }
    }
}
