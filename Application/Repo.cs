using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Application
{
    public abstract class Repo<T> 
    {
        
        public List<T> RepoCollection { get; private set; }
        public int Count { get
            {
                
                return RepoCollection.Count;
            }

        }
        public Repo()
        {
            RepoCollection = new List<T>();
        }
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
            for (int i = 0; i < RepoCollection.Count; i++)
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
