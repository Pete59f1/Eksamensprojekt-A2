using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    abstract class Repo<T>
    {
        public List<T> RepoCollection { get; private set; }

        public void AddItem(T number)
        {
            RepoCollection.Add(number);
        }
        public void RemoveItem(int number)
        {
            RepoCollection.RemoveAt(number);
        }
        public T GetItem(int number)
        {
            T item = RepoCollection[0];
            for (int i = 0; i < RepoCollection.Count - 1; i++)
            {
                if (i.Equals(number))
                {
                    item = RepoCollection[i];
                }
            }
            return item;
        }
    }
}
