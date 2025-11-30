using System.Diagnostics;

namespace Team_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine m = new("Минск", Frequency.Weekly, new DateTime(2010, 8, 20), 4000);
            m.Articles = new Article[]  { new Article(new Person("Егор", "Дедюля", new DateTime(2007, 8, 29)), "Минский театр", 7.4),
                                         new Article(new Person("Алексей", "Василенка", new DateTime(2007, 5, 23)), "Новая ветка метро в Минске", 9.0)
                                        };
            Console.WriteLine(m.ToShortString());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Значение индексатора для индекса Weekly: {m[Frequency.Weekly]}");
            Console.WriteLine($"Значение индексатора для индекса Monthly: {m[Frequency.Monthly]}");
            Console.WriteLine($"Значение индексатора для индекса Yearly : {m[Frequency.Yearly]}");
            m.Name = "Гродно";
            m.Type = Frequency.Monthly;
            m.Date = new DateTime(2019, 4, 10);
            m.Id = 2228;
            m.Articles = new Article[] { new Article(new Person("Дмитрий", "Нечай", new DateTime(2010, 3, 23)), "Каложская церковь", 5.2),
                                         new Article(new Person("Никита", "Бочкарев", new DateTime(2007, 11, 20)), "Реставрация гродненского театра", 7.6)};
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(m);
            m.AddArticles(new Article[] { new Article(new Person("Иван", "Жилинский", new DateTime(2007, 10, 4)), "Банановый рынок в Гродно", 10.0) });
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(m);
            int nRow;
            int nCol;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Введите число строк и столбцов двумерного и ступенчатого массивов, размер одномерного массива будет равен числу строк * число столбцов" +
                "\nВвести нужно два числа с разделителями между ними" +
                "\nВ качестве разделителя можно использовать символы |,\\, /, ., пробел");
            Console.Write("Ваш ввод: ");
            char[] separators = new char[] { ' ', '|', '\\', '/', '.' };
            string[] parts = Console.ReadLine().Split(separators);
            nRow = Convert.ToInt32(parts[0]);
            nCol = Convert.ToInt32(parts[1]);
            Console.WriteLine($"Число строк: {nRow}\nЧисло столбцов: {nCol}");

            Article[] oneDimensionalArray = new Article[nRow * nCol];
            for (int i = 0; i <= oneDimensionalArray.GetUpperBound(0); ++i)
                oneDimensionalArray[i] = new Article();
            var stopWatch = Stopwatch.StartNew();
            for (int i = 0; i <= oneDimensionalArray.GetUpperBound(0); ++i)
                oneDimensionalArray[i].Name = "Минск";
            stopWatch.Stop();
            Console.WriteLine($"Одномерный массив: {stopWatch.ElapsedMilliseconds} мс");

            Article[,] twoDimensionalArray = new Article[nRow, nCol];
            for (int i = 0; i <= twoDimensionalArray.GetUpperBound(0);  ++i)
            {
                for (int j = 0; j <= twoDimensionalArray.GetUpperBound(1); ++j)
                {
                    twoDimensionalArray[i, j] = new Article();
                }
            }
            stopWatch.Restart();
            for (int i = 0; i <= twoDimensionalArray.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= twoDimensionalArray.GetUpperBound(1); ++j)
                {
                    twoDimensionalArray[i, j].Name = "Минск";
                }
            }
            stopWatch.Stop();
            Console.WriteLine($"Двумерный массив: {stopWatch.ElapsedMilliseconds} мс");

            Article[][] jaggedArray = new Article[nRow][];
            for (int i = 0; i < nRow; ++i)
            {
                jaggedArray[i] = new Article[nCol];
                for (int j = 0; j < nCol; ++j)
                {
                    jaggedArray[i][j] = new Article();
                }
            }
            stopWatch.Restart();
            for (int i = 0; i <= jaggedArray.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= jaggedArray[i].GetUpperBound(0); ++j)
                {
                    jaggedArray[i][j].Name = "Минск";
                }
            }
            stopWatch.Stop();
            Console.WriteLine($"Ступенчатый массив: {stopWatch.ElapsedMilliseconds} мс");
        }
    }
}
