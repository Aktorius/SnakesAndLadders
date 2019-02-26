using SnakesAndLadders.Models.Global;

namespace SnakesAndLadders.Models.Extensions
{
    public static class TokenExtensions
    {
        public static void Move(this Token token, int spaces)
        {
            if (token.SquarePosition + spaces <= Constants.NumberOfSquares)
            {
                token.SquarePosition += spaces;
            }
        }
    }
}
