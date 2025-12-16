using System;
using System.Collections;

namespace Team_Project
{
    public class Magazine : Edition, IRateAndCopy
    {
        Frequency type;
        ArrayList articles;
        ArrayList editors;
        double rating;
        public Magazine(string name, Frequency type, DateTime date, int circulation, double rating) : base(name, date, circulation)
        {
            Type = type;
            articles = new ArrayList();
            editors = new ArrayList();
            Rating = rating;
        }
        public Frequency Type
        {
            get => type;
            set
            {
                type = value;
            }
        }
        public ArrayList Articles
        {
            get => articles;
            set
            {
                articles = value;
            }
        }
        public ArrayList Editors
        {
            get => editors;
            set
            {
                editors = value;
            }
        }
        public double AvgRating
        {
            get
            {
                double sum = 0;
                foreach (var i in articles)
                    sum += (i as Article).Rating;
                return sum / articles.Count;
            }
        }
        public double Rating
        {
            get => rating;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Рейтинг не может быть меньше нуля");
                rating = value;
            }
        }
        public Edition Edition
        {
            get => new Edition(name, date, circulation);
            set
            {
                name = value.Name;
                date = value.Date;
                circulation = value.Circulation;
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
            articles.Add(mass);
        }
        public void AddEditors(params Person[] mass)
        {
            editors.Add(mass);
        }
        public override string ToString()
        {
            string str = "";
            str = str + "Журнал " + name + "\nТип: " + type + "\nДата: " + date + "\nТираж: " + circulation;
            foreach (var item in articles)
            {
                str = str + item.ToString();
            }
            return str;
        }
        public virtual string ToShortString()
        {
            string str = "";
            str = str + "Журнал " + name + "\nТип: " + type + "\nДата: " + date + "Тираж: " + circulation + "\nСредний рейтинг: " + AvgRating.ToString();
            return str;
        }
        public override object DeepCopy()
        {
            Magazine magazine = new Magazine(name, type, date, circulation, rating);
            foreach (var item in articles)
                magazine.AddArticles((Article)(item as Article).DeepCopy());
            foreach (var item in editors)
                magazine.AddEditors((Person)(item as Person).DeepCopy());
            return magazine;
        }
        public IEnumerable GetArticlesByRating(double rating)
        {
            foreach (var item in articles)
            {
                Article article = item as Article;
                if (article != null && article.Rating > rating)
                    yield return article;
            }
        }
        public IEnumerable GetArticlesByName(string str)
        {
            foreach (var item in articles)
            {
                Article article = item as Article;
                if (article != null && article.Name.Contains(str))
                    yield return article;
            }
        }
    }
}