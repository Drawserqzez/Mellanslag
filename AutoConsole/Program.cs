using System;

namespace AutoConsole
{
    class Program
    {
        private static bool programExit = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Observer Pattern!!!");
            Console.WriteLine("We create three objects:");
            Console.WriteLine("The first adds a number in a list.");
            Console.WriteLine("The second adds a random char to a string.");
            Console.WriteLine("The third scrambles a string of characters incrementaly.");
            Console.WriteLine();
            Console.WriteLine("Creates Provider...");

            IProvider _provider = new OnEnterProvider();

            Console.WriteLine("Creating Subscribers and adds them to the Providers notify list...");
            
            ISubscriber _addingCharacter = new AddingCharacter();
            ISubscriber _addingNumber = new AddingNumber();
            ISubscriber _scrambelingData = new ScramblingData("This is a string to scramble!!");
            
            _provider.Subscribe(_addingCharacter);
            _provider.Subscribe(_addingNumber);
            _provider.Subscribe(_scrambelingData);

            Console.WriteLine("Objects start state:");
            Console.WriteLine($"{_addingNumber}");
            Console.WriteLine($"{_addingCharacter}");
            Console.WriteLine($"{_scrambelingData}");

            Console.WriteLine();
            Console.WriteLine("Observer starts and responds to the Enter Key");

            bool programExit = false;

            while(!programExit)
            {
                programExit = _provider.Update();
                Console.WriteLine($"\n{_addingNumber}");
                Console.WriteLine($"\n{_addingCharacter}");
                Console.WriteLine($"\n{_scrambelingData}");
                Console.WriteLine();
            }

            Console.WriteLine("Program exiting... Press Enter");
            Console.ReadKey();
        }
    }
}
