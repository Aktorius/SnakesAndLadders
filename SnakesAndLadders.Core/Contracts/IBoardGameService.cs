using SnakesAndLadders.Models;

namespace SnakesAndLadders.Core.Contracts
{
    public interface IBoardGameService
    {
        void PlayTurn(Token token, int spaces);
        bool IsGameWon();
    }
}
