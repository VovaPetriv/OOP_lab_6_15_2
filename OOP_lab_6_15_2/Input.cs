using System;
using System.IO;

namespace OOP_lab_6_15_2
{
    class Input : IInput
    {
        public void Read()
        {
            ReadBase();
            ReadKey();
        }

        public void ReadBase()
        {
            StreamReader file = new StreamReader("base.txt");

            string[] tempStr = file.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            new Work().InitialiseBase(tempStr.Length / 4);

            for (int i = 0; i < tempStr.Length; i += 4)
            {
                Program.week[i / 4] = new Day(tempStr[i], tempStr[i + 1], int.Parse(tempStr[i + 2]), tempStr[i + 3]);
            }

            file.Close();
        }

        public void ReadKey()
        {
            
        Start:

            Console.WriteLine("Додавання записiв: +");
            Console.WriteLine("Редагування записiв: E");
            Console.WriteLine("Знищення записiв: -");
            Console.WriteLine("Виведення записiв: Enter");
            Console.WriteLine("Загальна кiлькiсть вiдвiдувачiв: A");
            Console.WriteLine("Днi з максимальною кiлькiстю вiдвiдувачiв: M");
            Console.WriteLine("Записи з найбiльшою кiлькiстю слiв в коментарi: L");
            Console.WriteLine("Вихiд: Esc");

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.OemPlus:
                    new Work().Add();
                    goto Start;

                case ConsoleKey.E:
                    new Work().Edit();
                    goto Start;

                case ConsoleKey.A:
                    new Work().Sum();
                    goto Start;

                case ConsoleKey.M:
                    new Work().Maximum();
                    goto Start;

                case ConsoleKey.L:
                    new Work().LongestComent();
                    goto Start;

                case ConsoleKey.OemMinus:
                    new Work().Remove();
                    goto Start;

                case ConsoleKey.Enter:
                    new Output().Write();
                    goto Start;

                case ConsoleKey.Escape:
                    return;

                default:
                    Console.WriteLine();
                    goto Start;
            }
        }
    }
}
