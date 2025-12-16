using System;
namespace Team_Project {
	public class Article : IRateAndCopy
	{
		public Person Author { get; set; }
		public string Name { get; set; }
		public double Rating { get; set; }
		public Article(Person z, string y, double x)
		{
			Author = z;
			Name = y;
			Rating = x;
		}
		public Article() {
			Author = new Person();
		}
		public override string ToString()
		{
			return "Автор: \n" + Author.ToString() +"\nНазвание статьи: " + Name + "\nРейтинг: " + Rating;
		}

        public virtual object DeepCopy()
        {
			return new Article((Person)Author.DeepCopy(), Name, Rating);
        }
    }
}