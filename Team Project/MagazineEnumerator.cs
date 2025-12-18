using System;
using System.Collections;

namespace Team_Project
{
    public class MagazineEnumerator : IEnumerator<Article>
    {
        int currentIndex = -1;
        ArrayList articles;
        ArrayList editors;

        public MagazineEnumerator(ArrayList articles, ArrayList editors)
        {
            this.articles = articles;
            this.editors = editors;
        }

        public Article Current
        {
            get
            {
                if (currentIndex == -1 || currentIndex >= articles.Count)
                    throw new IndexOutOfRangeException("Индекс вышел за пределы списка статей");
                return (Article)articles[currentIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

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
