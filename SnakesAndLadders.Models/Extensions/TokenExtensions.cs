namespace SnakesAndLadders.Models.Extensions
{
    public static class TokenExtensions
    {
        public static void Move(this Token token, int spaces)
        {
            token.SquarePosition += spaces;
        }
    }
}
