using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    public class Repository<T> : IRepository<T> where T : IMachinery
    {
        public List<T> entities;

        public Repository()
        {
            entities = new List<T>();

        }
        public void Add(T entity)
        {
            entities.Add(entity);
        }
        public void Clear()
        {
            entities.Clear();
        }
        public int Count()
        {
            return entities.Count();
        }

        public void Print()
        {
            foreach (var entity in entities)
            {
                Console.WriteLine(entity);
            }
        }

        public void Remove(int index)
        {
            entities.RemoveAt(index);
        }


        public string GetMostPopularBrand()
        {
            //entities.ToArray();
            int res = 0;
            int count = 1;
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Brand == entities[i].Brand)
                {
                    count++;
                    return entities[i].Brand;
                }
                else
                {
                    count--;
                }
                if (count == 0)
                {
                    res = i;
                    count = 1;
                }
            }
            return entities[res].Brand;
        }
        public int GetTheCheapest()
        {
            int len = entities.Count;
            entities.ToArray();
            int min = entities[0].Price;
            for (int i = 0; i < len; i++)
            {
                if (entities[i].Price < min)
                {
                    min = entities[i].Price;
                    if (entities[i].Quantity == 0)
                    {
                        Console.WriteLine("Sorry this drone/robot" + entities[i].Brand + "is not available\n");
                    }
                }
            }
            return min;
        }
        public int GetQuantityOfMadeThisYear(int year)
        {
            int len = entities.Count;
            //entities.ToArray();
            int s = 0;
            for (int i = 0; i < len; i++)
            {
                if (entities[i].Year == year)
                {
                    s += entities[i].Quantity;
                }
            }
            if (s == 0)
            {
                throw new MyException(MyExceptionKind.WrongUserInputExeption, "\nError :Error try again\n");
            }
            return s;
        }

        public string ArrayToStr()
        {
            string temp = "";
            for (int i = 0; i < entities.Count; i++)
            {
                temp += entities[i].StringToFile();
            }
            return temp;
        }


    }
}
