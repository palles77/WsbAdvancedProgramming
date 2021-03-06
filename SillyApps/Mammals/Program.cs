using System;

namespace MyConsoleApp
{
    class Program
    {
        public static IMammal[] Mammals =
            new IMammal[]
            {
                new Elephant() {  CanFly = false, CanRun = true, Name = "Elephant Nr 1", TrumpetLenghtInCentimetres = 200},
                new Elephant() {  CanFly = true, CanRun = true, Name = "Elephant Nr 2", TrumpetLenghtInCentimetres = 220},
                new Ape() {  CanFly = true, CanRun = true, Name = "Ape Nr 2", HeightInCentimetres = 220}
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Here are my mammals...");

            for (int i = 0; i < Mammals.Length; i++)
            {
                var mammal = Mammals[i];
                Console.WriteLine(String.Format("Mammal nr: {0} which can fly: {1}, can run: {2}, and has a name: {3}",
                    i,
                    mammal.CanFly,
                    mammal.CanRun,
                    mammal.Name));

                Console.Write("Do you want to see the next mammal (Y/N)?");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.N)
                {
                    break;
                }
            }
        }
    }
}
