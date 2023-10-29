namespace TestingPurposes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Placeholder text
        }

        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {

            // This method will iterate over a List of strings, evaluate if
            // the word contains only valid & uppercase letters, checks for duplicate entries,
            // and return a List of each unique word.

            List<string> upperCaseList = new();

            foreach (string word in words)
            {
                bool wordIsUpper = true;
                bool containsSpecialCharacter = word.Any(c => !char.IsLetter(c));

                if (containsSpecialCharacter == true)
                {
                    continue;
                }

                if (upperCaseList.Contains(word))
                {
                    continue;
                }

                foreach (char character in word)
                {
                    bool isUpperCase = char.IsUpper(character);

                    if (!isUpperCase)
                    {
                        wordIsUpper = false;
                        break;
                    }
                }

                if (!wordIsUpper)
                {
                    continue;
                }

                upperCaseList.Add(word);
            }

            return upperCaseList;
        }
    }
}
