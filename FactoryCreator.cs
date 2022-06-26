using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    static public class FactoryCreator
    {
        public static IFactory GetFactory()
        {
            int userInput = 0;
            Console.WriteLine("Choose Factory :\n1) Memory Factory ;\n2) Text Factory ;\n");
            int.TryParse(Console.ReadLine(), out userInput);
            switch (userInput)
            {
                case 1:
                    return new MemoryFactory();
                    break;
                case 2:
                    return new TextFactory();
                    break;
                default:
                    throw new MyException(MyExceptionKind.WrongUserInputExeption, "\nError :Error try again\n");
                    break;
            }
        }
    }
}

