using System;
namespace Team_Project
{
    public class Magazine
    {
        private string name;
        private Frequency type;
        private DateTime date;
        private int id;
        private Article[] articles;
        Magazine(string name, Frequency type, int id, Article[] article1)
        {
            Name = name;
            Type = type;
            Id = id;
            articles = article1;
        }
        public string Name
        {
            get => name;
            set {
                name = value;
            }
        }
        public Frequency Type
        {
            get => type;
            set
            {
                type = value;
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
            }
        }
        public int Id
        {
            get => id;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Невернео значение!");
                id = value;
            }
        }
        public Article[] Articles
        {
            get => articles;
            set
            {
                articles = value;
            }
        }
        public double AvgRating
        {
            get
            {
                double sum = 0;
                foreach (var i in articles)
                    sum += i.Rating;
                return sum / articles.Length;
            }
        }
        public bool this[Frequency f]
        {
            get
            {
                return f == type;
            }
        }
        public void AddArticles(params Article[] mass)
        {
            Article[] arr = new Article[mass.Length+articles.Length];
            int index=0;
            for (int i=0;i<mass.Length;++i)
            {
                arr[index++] = mass[i];
            }
            for (int i = 0; i < articles.Length; ++i)
            {
                arr[index++] = articles[i];
            }
            articles = arr;
        }
        public override string ToString()
        {
            string zxc = "";
            zxc = zxc + "Название: " + name + "Тип: " + type + "Дата: " + date + "id: " + id;
            foreach (var item in articles)
            {
                zxc=zxc+item.ToString();
            }
            return zxc;
        }
        public virtual string ToShortString()
        {
            string zxc = "";
            zxc = zxc + "Название: " + name + "Тип: " + type + "Дата: " + date + "id: " + id+"Средний рейтинг"+AvgRating.ToString();
            return zxc;
        }
    }
}