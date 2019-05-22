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
        public void AddItem(T index)
        {
            RepoCollection.Add(index);
        }
        public void RemoveItem(int index)
        {
            RepoCollection.RemoveAt(index);
        }
        public T GetItem(int index)
        {
            T item = RepoCollection[0];
            for (int i = 0; i < RepoCollection.Count; i++)
            {
                if (i.Equals(index))
                {
                    item = RepoCollection[i];
                }
            }
            return item;
        }
        

       
    }
}
