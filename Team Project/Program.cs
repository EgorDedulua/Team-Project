using System.Collections;
namespace Team_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edition e1 = new("Минск", new DateTime(2025, 12, 18), 3000);
            Edition e2 = new("Минск", new DateTime(2025, 12, 18), 3000);
            Console.WriteLine($"Издание 1:\n{e1}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Издание 2:\n{e2}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Издание 1 == Издание 2 = {e1 == e2}");
            Console.WriteLine($"Хеш-код издания 1: {e1.GetHashCode()}");
            Console.WriteLine($"Хеш-код издания 2: {e2.GetHashCode()}");
            try
            {
                e1.Circulation = -1000;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Magazine m = new("Наука", Frequency.Weekly, new DateTime(2025, 8, 10), 4000, 9.6);
            m.AddArticles(new Article[]{ new Article(new Person("Дмитрий", "Нечай", new DateTime(2004, 3, 14)), "Космос", 8.2),
                                         new Article(new Person("Виктор", "Нечай", new DateTime(2002, 5, 16)), "Компьютер", 7),
                                         new Article(new Person("Никита", "Бочкарев", new DateTime(2006, 11, 24)), "Уголь", 4.99),
                                         new Article(new Person("Артем", "Шкатуло", new DateTime(2010, 4, 16)), "Алмаз", 10)
            });
            m.AddEditors(new Person[] { new Person("Дмитрий", "Нечай", new DateTime(2004, 3, 14)),
                                        new Person("Никита", "Бочкарев", new DateTime(2006, 11, 24)),
                                        new Person("Егор", "Дедюля", new DateTime(2007, 8, 29)),
                                        new Person("Алексей", "Василенка", new DateTime(2003, 9, 19))
            });
            Console.WriteLine("------------------------------------");
            Console.WriteLine(m);
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Значение свойства типа Edition у объекта Magazine:\n{m.Edition}");
            Console.WriteLine("------------------------------------");
            Magazine mCopy = (Magazine)m.DeepCopy();
            m.Name = "Спорт";
            m.AddArticles(new Article(new Person("Егор", "Дедюля", new DateTime(2007, 8, 29)), "Математика", 6));
            Console.WriteLine($"Копия объекта Magazine:\n{mCopy}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Измененный исходный объект Magazine:\n{m}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Статьи с рейтингом больше 8:");
            foreach (var item in m.GetArticlesByRating(8))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Статьи, в названии которых есть строка Ко:");
            foreach (var item in m.GetArticlesByName("Ко"))
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Статьи, авторы которых не являются редакторами журналов:");
            foreach (Article item in m)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Статьи, авторы которых являются редакторами журналов:");
            foreach (Article item in m.GetArticlesWithEditors())
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Редакторы, у которых нет статей в журнале:");
            foreach (Person item in m.GetEditorsWithoutArticles())
            {
                Console.WriteLine(item); 
            }
        }
    }
}
