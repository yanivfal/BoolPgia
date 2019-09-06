using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoolPgiaLogic
{
    public class GameManager
    {
        private const int k_LengthOfGuess = 4;
        private const int k_MaxNumOfGuesses = 10;
        private const int k_MinNumOfGuesses = 4;      
        private const int k_MinCharToGuess = 'A';
        private const int k_MaxCharToGuess = 'H';
        private readonly int r_NumOfGuesses;
        private int m_CurrentNumOfSteps = 0;
        private string m_Solution = null;
        private bool m_IsPlayerWon = false;
        private bool m_IsPlayerLost = false;

        public GameManager(int i_NumOfGuesses)
        {
            r_NumOfGuesses = i_NumOfGuesses;
            m_Solution = generateSolution();
        }

        public int CurrentNumOfSteps
        {
            get
            {
                return m_CurrentNumOfSteps;
            }
            set
            {
                m_CurrentNumOfSteps = value;
                if (!m_IsPlayerWon)
                {
                    m_IsPlayerLost = isGameOver();
                }       
            }
        }

        public bool IsPlayerWon
        {
            get
            {
                return m_IsPlayerWon;
            }
        }

        public bool IsPlayerLost
        {
            get
            {
                return m_IsPlayerLost;
            }
        }

        public static int MinNumOfGuesses
        {
            get
            {
                return k_MinNumOfGuesses;
            }
        }

        public static int MaxNumOfGuesses
        {
            get
            {
                return k_MaxNumOfGuesses;
            }
        }

        public string Solution
        {
            get
            {
                return m_Solution;
            }
        }

        private static string generateSolution()
        {
            List<char> solutionList = new List<char>();
            byte solutionLength = 0;
            Random rand = new Random();
            char randChar;

            while (solutionLength < k_LengthOfGuess)
            {
                randChar = (char)rand.Next(k_MinCharToGuess, k_MaxCharToGuess + 1);
                if (!solutionList.Contains(randChar))
                {
                    solutionList.Add(randChar);
                    solutionLength++;
                }
            }

            return (new string(solutionList.ToArray()));
        }

        public bool GetResults(string i_NewGuess, out int o_NumberOfBool, out int o_NumberOfPgia)
        {    
            StringBuilder resultsSB = new StringBuilder();
            string guessWithOutSpaces = i_NewGuess.Replace(" ", string.Empty);
            string solutionWithOutSpaces = m_Solution.Replace(" ", string.Empty);
            bool isValidGuess = IsValidGuess(guessWithOutSpaces);

            o_NumberOfPgia = 0;
            o_NumberOfBool = 0;
            if (isValidGuess)
            {
                
                for (int i = 0; i < solutionWithOutSpaces.Length; i++)
                {
                    if (guessWithOutSpaces[i] == solutionWithOutSpaces[i])
                    {
                        o_NumberOfBool++;
                    }
                }

                for (int i = 0; i < solutionWithOutSpaces.Length; i++)
                {
                    if (guessWithOutSpaces[i] != solutionWithOutSpaces[i] && solutionWithOutSpaces.Contains(guessWithOutSpaces[i]))
                    {
                        o_NumberOfPgia++;
                    }
                }

                if (o_NumberOfBool == k_LengthOfGuess)
                {
                    m_IsPlayerWon = true;
                }
            }
           
            return isValidGuess;
        }

        private bool IsValidGuess(string i_UserGuessStr)
        {
            bool isValidGuess = true;

            if (i_UserGuessStr.Length != k_LengthOfGuess)
            {
                isValidGuess = false;
            }

            foreach (char c in i_UserGuessStr)
            {
                if (!(c >= k_MinCharToGuess && c <= k_MaxCharToGuess))
                {
                    isValidGuess = false;
                }
            }

            if (!(i_UserGuessStr.Distinct().Count() == k_LengthOfGuess))
            {
                isValidGuess = false;
            }

            return isValidGuess;
        }

        private bool isGameOver()
        {
            bool isGameOver = false;

            if (CurrentNumOfSteps == r_NumOfGuesses)
            {
               isGameOver = true;
            }

            return isGameOver;
        }
    }  
}
