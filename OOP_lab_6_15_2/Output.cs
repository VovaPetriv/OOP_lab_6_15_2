using System;

namespace OOP_lab_6_15_2
{
    class Output : IOutput
    {
        public const string Format = "{0, -20} {1, -35} {2, -15} {3, -10}";

        public void Write()
        {
            Console.WriteLine(Format, "Назва", "Прiзвище скульптора", "Кiлькiсть вiдвiдувачiв", "Коментар");

            for (int i = 0; i < Program.week.Length; ++i)
            {
                Console.WriteLine(Format, Program.week[i].Name, Program.week[i].SculptorSurename, Program.week[i].VisitorsCount, Program.week[i].Coment);
            }
        }
    }
}
