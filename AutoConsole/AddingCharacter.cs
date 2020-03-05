using System;

namespace AutoConsole
{
    public class AddingCharacter : ISubscriber
    {
        private string _characters;

        public AddingCharacter()
        {
            _characters = "";
        }

        public void Update()
        {
            //33 - 126
            Random rand = new Random();
            _characters += (char)rand.Next(32, 126);
        }

        public override string ToString()
        {
            return $"Characters in object: {_characters}";
        }
    }
}