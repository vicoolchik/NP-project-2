using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    public class DroneRepesitory : Repository<Drone>
    {
        Repository<Drone> r;
        private int CountStartWork;
        public DroneRepesitory()
        {
        }

        public Repository<Drone> ReturnAppendArray()
        {
            Repository<Drone> r = new Repository<Drone>();
            List<string> lines = Work_File.GetInfoFromFileToList();
            foreach (string line in lines)
            {
                Drone machineryFromFile = Work_File.FromLineToIMachinery(line);
                r.Add(machineryFromFile);
            }
            return r;
        }
        public void ArrayApdate()
        {
            List<string> animalCount = Work_File.GetInfoFromFileToList();
            if ((animalCount.Count()) != CountStartWork)
            {
                r.Clear();
                AppendArray();
            }
        }
        public void Clear() { r.Clear(); }
        public void AppendArray() { r = ReturnAppendArray(); CountStartWork = r.Count(); }
        public void Print(){r.Print();}   
        public void Add(Drone entity) { r.Add(entity); }
        public void Remove(int index) { r.Remove(index); }
        public string GetMostPopularBrand() { return r.GetMostPopularBrand();}
        public int GetTheCheapest() { return r.GetTheCheapest(); }
        public int GetQuantityOfMadeThisYear(int year) { return r.GetQuantityOfMadeThisYear(year); }
        public string ArrayToStr() {return  r.ArrayToStr(); }
    }
}
