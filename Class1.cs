namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        // Example: Check if string is null or empty
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        // Example: Reverse a string
        public static string Reverse(this string str)
        {
            if (str == null) return null;
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Example: Capitalize first letter
        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
