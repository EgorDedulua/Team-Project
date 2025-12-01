using System;


namespace Team_Project
{
    public class Person
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
            FirstName = "Не укказано"; LastName = "Не указано"; BirthDate = new DateTime(2000, 1, 1);
        }

        public override string ToString() => $"Имя: {FirstName}\nФамилия: {LastName}\nДата рождения: {BirthDate.ToShortDateString()}";

        public virtual string ToShortString() => $"Имя: {FirstName}\nФамилия: {LastName}";
    }
}
