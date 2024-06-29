namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(123);
        }

        public static bool IsPalindrome(int x)
        {
            string input = x.ToString();
            var len = input.Length-1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[len - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}