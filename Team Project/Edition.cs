using System;

namespace Team_Project
{
    public class Edition
    {
        protected string name;
        protected DateTime date;
        protected int circulation;
        public Edition(string name, DateTime date, int circulation)
        {
            this.name = name; this.date = date; this.circulation = circulation;
        }
        public Edition() { }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Circulation
        {
            get => circulation;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Тираж должен быть больше нуля");
                circulation = value;
            }
        }
        public virtual object DeepCopy()
        {
            return new Edition(name, date, circulation);
        }
        public override bool Equals(object? obj)
        {
            if (obj is Edition edition)
                return name == edition.name && date == edition.date && circulation == edition.circulation;
            return false;
        }
        public static bool operator ==(Edition? edition1, Edition? edition2)
        {
            if (edition1 is null && edition2 is null)
                return true;

            if (edition1 is null || edition2 is null)
                return false;

            return edition1.Equals(edition2);
        }
        public static bool operator !=(Edition? edition1, Edition? edition2)
        {
            return !(edition1 == edition2);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(name, date, circulation);
        }
        public override string ToString()
        {
            return $"Издание {name}:\nДата выпуска: {date.ToShortDateString()}\nТираж: {circulation}";
        }
    }
}