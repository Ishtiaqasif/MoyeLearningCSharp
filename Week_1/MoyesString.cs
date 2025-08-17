namespace Week_1
{
    internal static class MoyesString
    {
        public static string Capped(string s)
        {
            return s.ToUpper();
        }

        public static int WordCount(string sen)
        {
            if (sen.Length == 0)
                return 0;
            int result = 1;
            foreach (char ch in sen)
            {
                if (ch == ' ')
                    result = result + 1;
            }
            return result;
        }

        public static int CharCount(string sentence)
        {
            int count = 0;

            foreach (char ch in sentence)
            {
                if (ch == ' ')
                {
                    count--;
                }

                count++;
            }
            return count;
        }

        public static int CharCount(string sentence, char a)
        {
            int result = 0;
            foreach (char ch in sentence)
            {
                if (ch == a)
                    result = result + 1;
            }
            return result;
        }

        public static (int, int) Word_and_Character_Count(string sentence)
        {
            int wordCount = WordCount(sentence);
            int charCount = CharCount(sentence);

            return (wordCount, charCount);
        }
    }
}