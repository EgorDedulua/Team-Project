
namespace Team_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Magazine m = new("Минск", Frequency.Weekly, new DateTime(2010, 8, 20), 4000);
            //m.Articles = new Article[]  { new Article(new Person("Егор", "Дедюля", new DateTime(2007, 8, 29)), "Минский театр", 7.4),
            //                             new Article(new Person("Алексей", "Василенка", new DateTime(2007, 5, 23)), "Новая ветка метро в Минске", 9.0)
            //                            };
            //Console.WriteLine(m.ToShortString());
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine($"Значение индексатора для индекса Weekly: {m[Frequency.Weekly]}");
            //Console.WriteLine($"Значение индексатора для индекса Monthly: {m[Frequency.Monthly]}");
            //Console.WriteLine($"Значение индексатора для индекса Yearly : {m[Frequency.Yearly]}");
            //m.Name = "Гродно";
            //m.Type = Frequency.Monthly;
            //m.Date = new DateTime(2019, 4, 10);
            //m.Id = 2228;
            //m.Articles = new Article[] { new Article(new Person("Дмитрий", "Нечай", new DateTime(2010, 3, 23)), "Каложская церковь", 5.2),
            //                             new Article(new Person("Никита", "Бочкарев", new DateTime(2007, 11, 20)), "Реставрация гродненского театра", 7.6)};
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(m);
            //m.AddArticles(new Article[] { new Article(new Person("Иван", "Жилинский", new DateTime(2007, 10, 4)), "Банановый рынок в Гродно", 10.0) });
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(m);
            //int nRow;
            //int nCol;
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Введите число строк и столбцов двумерного и ступенчатого массивов, размер одномерного массива будет равен числу строк * число столбцов" +
            //    "\nВвести нужно два числа с разделителями между ними" +
            //    "\nВ качестве разделителя можно использовать символы |,\\, /, ., пробел");
            //Console.Write("Ваш ввод: ");
            //char[] separators = new char[] { ' ', '|', '\\', '/', '.' };
            //string[] parts = Console.ReadLine().Split(separators);
            //nRow = Convert.ToInt32(parts[0]);
            //nCol = Convert.ToInt32(parts[1]);
            //Console.WriteLine($"Число строк: {nRow}\nЧисло столбцов: {nCol}");

            //Article[] oneDimensionalArray = new Article[nRow * nCol];
            //for (int i = 0; i <= oneDimensionalArray.GetUpperBound(0); ++i)
            //    oneDimensionalArray[i] = new Article();
            //var stopWatch = Stopwatch.StartNew();
            //for (int i = 0; i <= oneDimensionalArray.GetUpperBound(0); ++i)
            //    oneDimensionalArray[i].Name = "Минск";
            //stopWatch.Stop();
            //Console.WriteLine($"Одномерный массив: {stopWatch.ElapsedMilliseconds} мс");

            //Article[,] twoDimensionalArray = new Article[nRow, nCol];
            //for (int i = 0; i <= twoDimensionalArray.GetUpperBound(0);  ++i)
            //{
            //    for (int j = 0; j <= twoDimensionalArray.GetUpperBound(1); ++j)
            //    {
            //        twoDimensionalArray[i, j] = new Article();
            //    }
            //}
            //stopWatch.Restart();
            //for (int i = 0; i <= twoDimensionalArray.GetUpperBound(0); ++i)
            //{
            //    for (int j = 0; j <= twoDimensionalArray.GetUpperBound(1); ++j)
            //    {
            //        twoDimensionalArray[i, j].Name = "Минск";
            //    }
            //}
            //stopWatch.Stop();
            //Console.WriteLine($"Двумерный массив: {stopWatch.ElapsedMilliseconds} мс");

            //Article[][] jaggedArray = new Article[nRow][];
            //for (int i = 0; i < nRow; ++i)
            //{
            //    jaggedArray[i] = new Article[nCol];
            //    for (int j = 0; j < nCol; ++j)
            //    {
            //        jaggedArray[i][j] = new Article();
            //    }
            //}
            //stopWatch.Restart();
            //for (int i = 0; i <= jaggedArray.GetUpperBound(0); ++i)
            //{
            //    for (int j = 0; j <= jaggedArray[i].GetUpperBound(0); ++j)
            //    {
            //        jaggedArray[i][j].Name = "Минск";
            //    }
            //}
            //stopWatch.Stop();
            //Console.WriteLine($"Ступенчатый массив: {stopWatch.ElapsedMilliseconds} мс");
            Magazine m = new("FutureTech", Frequency.Monthly, new DateTime(2025, 2, 1), 5000);
            Console.WriteLine(m.ToShortString());
            Console.WriteLine($"Значение индексатора для индекса Weekly: {m[Frequency.Weekly]}");
            Console.WriteLine($"Значение индексатора для индекса Monthly: {m[Frequency.Monthly]}");
            Console.WriteLine($"Значение индексатора для индекса Yearly: {m[Frequency.Yearly]}");
            m.Type = Frequency.Yearly;
            m.Id = 10000;
            m.AddArticles(new Article[] { new Article(new Person("Иван", "Иванов", new DateTime(1985, 5, 12)), "Проектирование ПО", 9.0)});
            Console.WriteLine(m);
            m.AddArticles(new Article[] { new Article(new Person("Анна", "Сидорова", new DateTime(2000, 3, 15)), "Теория вычислительных процессов", 8.0),
                                          new Article(new Person("Мария", "Кузнецова", new DateTime(1980, 10, 10)), "ИБ и право", 10.0)});
            foreach (var item in m.Articles)
            {
                if (item.Rating > 8.0)
                    Console.WriteLine(item);
            }
            Console.WriteLine(m);
            Magazine m1 = new Magazine("ScienceToday", Frequency.Weekly, new DateTime(2025, 2, 2), 3000);
            m1.AddArticles(new Article[] { new Article(new Person("Анна", "Лебедева", new DateTime(2001, 2, 2)), "ООП", 8.0),
                                           new Article(new Person("Анна", "Лебедева", new DateTime(2001, 2, 2)), "Алгоритмы", 9.0)});
            Magazine m2 = new Magazine("NetworkWorld", Frequency.Monthly, new DateTime(2025, 3, 3), 4000);
            m2.AddArticles(new Article[] { new Article(new Person("Борис", "Михайлов", new DateTime(2000, 3, 3)), "Сети", 7.0)});
            Magazine m3 = new Magazine("CyberSecurity", Frequency.Yearly, new DateTime(2025, 4, 4), 6000);
            m3.AddArticles(new Article[] { new Article(new Person("Екатерина", "Соловьева", new DateTime(1999, 4, 4)), "ИБ", 10.0),
                                           new Article(new Person("Екатерина", "Соловьева", new DateTime(1999, 4, 4)), "Право", 10.0),
                                           new Article(new Person("Екатерина", "Соловьева", new DateTime(1999, 4, 4)), "Архитекртура ПО", 9.0)});
            Magazine[] magazines = new Magazine[] { m1, m2, m3};
            foreach (var magazine in magazines.OrderBy(m => m.AvgRating))
                Console.WriteLine(magazine.ToShortString());
        }
    }
}
