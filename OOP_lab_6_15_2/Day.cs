using System;

namespace OOP_lab_6_15_2
{
    class Day : Exhibition
    {
        private int _visitorsCount;
        private string _coment; 

        public int VisitorsCount
        {
            get => _visitorsCount;
            set => _visitorsCount = value;
        }

        public string Coment
        {
            get => _coment;
            set => _coment = value;
        }

        public virtual int ComentLength()
        {
            return _coment.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public Day()
        {
            base.Name = "Не вказано.";
            base.SculptorSurename = "Не вказано.";

            _visitorsCount = 0;
            _coment = "Не вказано";
        }

        public Day(string name, string sculptorSurename, int visitorsCount, string coment)
        {
            base.Name = UkrainianI(name); ;
            base.SculptorSurename = UkrainianI(sculptorSurename);

            _visitorsCount = visitorsCount;
            _coment = UkrainianI(coment);
        }
    }
}
