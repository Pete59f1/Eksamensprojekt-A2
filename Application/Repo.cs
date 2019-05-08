using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Application
{
    public abstract class Repo<T> : INotifyPropertyChanged
    {
        
        public List<T> RepoCollection { get; private set; }
        public int Count { get
            {
                OnPropertyChanged(nameof(Count));
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
            for (int i = 0; i < RepoCollection.Count - 1; i++)
            {
                if (i.Equals(number))
                {
                    item = RepoCollection[i];
                }
            }
            return item;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
