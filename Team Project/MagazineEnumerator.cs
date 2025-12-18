using System;
using System.Collections;

namespace Team_Project
{
    public class MagazineEnumerator : IEnumerator<Magazine>
    {
        int currentIndex = -1;
        ArrayList articles;
        ArrayList editors;

        public MagazineEnumerator(ArrayList articles, ArrayList editors)
        {
            this.articles = articles;
            this.editors = editors;
        }

        public Magazine Current
        {
            get
            {
                if (currentIndex == -1 || currentIndex >= articles.Count)
                    throw new IndexOutOfRangeException("Индекс вышел за пределы списка статей");
                return (Magazine)articles[currentIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            while (true)
            {
                currentIndex++;

                if (currentIndex >= articles.Count)
                    return false;
                
                Article article = (Article)articles[currentIndex];
                if (article != null)
                {
                    bool isEditor = false;
                    foreach (Person editor in editors)
                    {
                        if (article.Author.Equals(editor))
                        {
                            isEditor = true;
                            break;
                        }
                    }

                    if (!isEditor)
                        return true;
                }
            }
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
