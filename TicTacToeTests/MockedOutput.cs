using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToeTests
{
    internal class MockedOutput : IUserOutput
    {
        public void Display(string str)
        {
            //DO NOTHING
        }
    }
}