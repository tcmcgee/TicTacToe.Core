using System;
using System.Runtime.CompilerServices;
using TicTacToe.Core;

namespace TicTacToeTests
{
    internal class MockedIO : IIO
    {
        private IUserInput input;
        private IUserOutput output;

        public MockedIO(IUserInput input, IUserOutput output)
        {
            this.input = input;
            this.output = output;
        }

        public string DisplayWelcomeMessage()
        {
            return "";
        }

        public string DisplayBoard(Board board)
        {
            return "";
        }

        public string DisplayGameOverMessage(bool turn, bool tie)
        {
            return "";
        }

        public bool GetPlayAgain()
        {
            return false;
        }

        public string DisplayHelp(Board board)
        {
            return "";
        }

        public int GetPlayerMove(Board board)
        {
            return Int32.Parse(input.GetInput());
        }
    }
}