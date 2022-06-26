using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Print();
        void Remove(int index);
        string GetMostPopularBrand();
        int GetTheCheapest();
        int GetQuantityOfMadeThisYear(int year);
        void Clear();
    }
}

