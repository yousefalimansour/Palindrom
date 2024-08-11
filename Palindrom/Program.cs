namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(s));
        }
        public static bool IsPalindrome(string s)
        {
            int pointer1 = 0;
            int pointer2 = s.Length - 1;
            while (pointer1 < pointer2)
            {
                if (!char.IsLetterOrDigit(s[pointer1])) pointer1++;
                else if (!char.IsLetterOrDigit(s[pointer2])) pointer2--;
                else
                {
                  if (char.ToLower(s[pointer1]) != char.ToLower(s[pointer2]))
                        return false;
                    pointer1++;
                    pointer2--;
                }
                
            }
            return true;
        }

      
    }
}
