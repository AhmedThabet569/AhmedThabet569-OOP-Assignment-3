using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IHasId
    {
        int Id { get; }
    }
    public class Store<T> where T: IHasId
    {
        private readonly Dictionary<int, T> values = new();

        public void Add(T item)
        {
            values.Add(item.Id,item);
        }

        public T? GetById(int id)
        {
            return values.GetValueOrDefault(id);
        }
        public Dictionary<int,T> GetAll()
        {
            return values;
        }
        public bool remove(int id)
        {
            //foreach (T item in values)
            //{
            //    if (item.Id == id)
            //        values.Remove(item);
            //}
            return values.Remove(id);
        }
    }
}
