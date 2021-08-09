using System;

namespace ConsoleTest
{
    public class ReadWriteExecute
    {
        public static int SymbolicToOctal(string permString)
        {
            string result = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                result += CountSeparatedBlocks(permString.Substring(i * 3, 3)).ToString();
            }

            return Convert.ToInt32(result);
        }

        private static int ConvertCharacterToInt(char character)
        {
            return char.ToLower(character) switch
            {
                'r' => 4,
                'w' => 2,
                'x' => 1,
                _ => 0,
            };
        }

        private static int CountSeparatedBlocks(string separatedBlock)
        {
            var sum = 0;

            foreach (char c in separatedBlock)
            {
                var value = ConvertCharacterToInt(c);
                sum += value;
            }

            return sum;
        }
    }
}
