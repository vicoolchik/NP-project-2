using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    public interface IMachinery
    {
        string Brand { get; set; }
        //string Model { get; set; }
        //string Function { get; set; }
        int Year { get; set; }
        int Price { get; set; }
        int Quantity { get; set; }
        string StringToFile();
    }
}

