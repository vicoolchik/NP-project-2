using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2_1_
{
    class TextRepository<T> : Repository<T> where T : IMachinery
    {
        private const string filePath = @"C:\Users\goryn\Documents\projects\Task2[1]\Task2[1]\drone.txt";
        public static List<string> GetInfoFromFileToList()
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return lines;
        }

    }






}
