using System;

namespace AutoConsole
{
    public class ScramblingData : ISubscriber
    {
        private string _dataToScramble;

        public ScramblingData(string data)
        {
            _dataToScramble = data;
        }

        public void Update()
        {
            // Moves a random character in the _dataToScramble
            Random rand = new Random();
            int charIndexFirst = rand.Next(_dataToScramble.Length);
            int charIndexSecond = rand.Next(_dataToScramble.Length);
            char tempOne = _dataToScramble[charIndexFirst];
            char tempTwo = _dataToScramble[charIndexSecond];
            char[] tempChars = _dataToScramble.ToCharArray();
            tempChars[charIndexFirst] = tempTwo;
            tempChars[charIndexSecond] = tempOne;
            _dataToScramble = new string(tempChars);
        }

        public override string ToString()
        {
            return $"Scrambled string: {_dataToScramble}";
        }
    }
}