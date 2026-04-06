namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return char.IsUpper(input[0]);
        }
    }
}