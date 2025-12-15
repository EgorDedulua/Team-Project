using System;


namespace Team_Project
{
    internal class Person
    {
        string? _firstName;
        string? _lastName;
        DateTime _birthDate;

        public string? FirstName
        {
            get => _firstName; set => _firstName = value;
        }

        public string? LastName
        { 
            get => _lastName; set => _lastName = value;
        }

        public DateTime BirthDate
        {
            get => _birthDate; set => _birthDate = value;
        }

        public int BirthYear
        {
            get => _birthDate.Year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Год рождения не может быть меньше нуля");
                if (value > DateTime.Now.Year)
                    throw new ArgumentException("Год рождения не может быть больше текущего года");
                _birthDate = new DateTime(value, _birthDate.Month, _birthDate.Day);
            }
        }

        public Person(string? firstName, string? lastName, DateTime birthDate)
        {
            FirstName = firstName; LastName = lastName; BirthDate = birthDate;
        }

        public Person()
        {
            FirstName = "Не укказано"; LastName = "Не указано"; BirthDate = new DateTime(2000, 0, 1);
        }

        public override string ToString() => $"Имя: {FirstName}\nФамилия: {LastName}\n Дата рождения: {BirthDate}";

        public override bool Equals(object? obj)
        {
            if (obj is Person other)
            {
                return BirthDate == other.BirthDate && FirstName == other.FirstName && LastName == other.LastName;
            }
            return false;
        }

        public static bool operator ==(Person? a, Person? b)
        {
            if (a == null && b == null)
                return true;

            if (a == null || b == null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, _birthDate);
        }

        public virtual object DeepCopy()
        {
            return new Person(_firstName, _lastName, _birthDate);
        }
    }
}
