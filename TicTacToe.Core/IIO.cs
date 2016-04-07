using System.Security.Cryptography.X509Certificates;
using TicTacToe.Core;

namespace TicTacToe.Core
{
    public interface IIO
    {
        string DisplayWelcomeMessage();

        string DisplayBoard(Board board);

        string DisplayGameOverMessage(bool turn, bool tie);

        bool GetPlayAgain();

        string DisplayHelp(Board board);

        int GetPlayerMove(Board board);
    }
}