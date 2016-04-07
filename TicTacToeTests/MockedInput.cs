using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToeTests
{
    internal class MockedInput : IUserInput
    {
        private string mockedInput;

        public MockedInput(string mockedInput)
        {
            this.mockedInput = mockedInput;
        }

        public string GetInput()
        {
            return mockedInput;
        }
    }
}