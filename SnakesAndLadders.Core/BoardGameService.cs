using SnakesAndLadders.Core.Contracts;
using SnakesAndLadders.Models;
using SnakesAndLadders.Models.Extensions;
using SnakesAndLadders.Models.Global;

namespace SnakesAndLadders.Core
{
    public class BoardGameService : IBoardGameService
    {
        private bool _isGameWon;

        public BoardGameService()
        {
            _isGameWon = false;
        }

        public void PlayTurn(Token token, int spaces)
        {
            token.Move(spaces);

            CheckIfGamesIsWon(token);
        }

        public bool IsGameWon()
        {
            return _isGameWon;
        }

        private void CheckIfGamesIsWon(Token token)
        {
            _isGameWon = token.SquarePosition == Constants.numberOfSquares;
        }
    }
}
