using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using Admin;
namespace Task2_1_
{
    public class Work_File
    {
        private const string filePath = @"C:\work\c#\Task2_1_\Task2_1_\drone.txt";
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
                Console.WriteLine(e.Message);
            }
            return lines;
        }
        public static Drone FromLineToIMachinery(string line)
        {
            Drone machineryFromLine = new Drone();

            if (line[0] == 'd')
            {
                string[] tempLine = line.Split(',');
                machineryFromLine.Brand = tempLine[0];
                machineryFromLine.Model = tempLine[1];
                machineryFromLine.Year = Int32.Parse(tempLine[2]);
                machineryFromLine.Price = Int32.Parse(tempLine[3]);
                machineryFromLine.Quantity = Int32.Parse(tempLine[4]);
            }
            return machineryFromLine;
        }

        public void WriteInfoToFile(DroneRepesitory droneRepository)
        {

            try
            {
                string infoToFile = "";
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    infoToFile += droneRepository.ArrayToStr();
                    //infoToFile += robotRepository.ArrayToStr();


                    sw.Write(infoToFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*public static void WriteInfoToFile()
    {
        try
        {
            string infoToFile = "";
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {




                sw.Write(infoToFile);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }*/



