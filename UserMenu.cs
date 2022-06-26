using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_;

namespace User
{
    class UserMenu
    {
        DroneRepesitory droneRepository;
        IRepository<Robot> robotRepository;
        //DroneRepesitory dr;

        public UserMenu()
        {
            var factory = FactoryCreator.GetFactory();
            droneRepository = factory.GetDroneRepository();
            robotRepository = factory.GetRobotRepository();
            //dr = new DroneRepesitory();
        }

        public void ShowMenu()
        {
            string userInput = "";
            if (droneRepository.GetType() == typeof(DroneRepesitory)) { droneRepository.AppendArray(); };
            var myExeption = WriteErrorToFile.Instance;
            do
            {
                try
                {
                    ShowMainMenu();
                    userInput = Console.ReadLine();
                    droneRepository.ArrayApdate();
                    ExecuteUserCommand(userInput);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    myExeption.WriteText($"{e.Data}{e.Message}\n");
                }

            }
            while (userInput != "0");
            myExeption.Save();
        }

        void ShowMainMenu()
        {
            string menu = @"Production of robots and drones
Please choose the option:
1 - Print drones;
2 - Print robots;
3 - Get most popular drone and robot brand;
4 - Get the cheapest drone and robot;
5 - Show quantity of drones and robots made in this yeah;
0 - Exit";
            Console.WriteLine(menu);
        }

        void ExecuteUserCommand(string userInput)
        {

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Drones:");
                    droneRepository.Print();
                    break;
                case "2":
                    Console.WriteLine("Robots:");
                    robotRepository.Print();
                    break;
                case "3":
                    Console.WriteLine("Most popular drone brand is " + droneRepository.GetMostPopularBrand() + "\n");
                    Console.WriteLine("Most popular robot brand is " + robotRepository.GetMostPopularBrand() + "\n");
                    break;
                case "4":
                    Console.WriteLine("Most cheapest drone cost " + droneRepository.GetTheCheapest() + "\n");
                    Console.WriteLine("Most cheapest robot cost " + robotRepository.GetTheCheapest() + "\n");
                    break;
                case "5":
                    int year2;
                    Console.WriteLine("Show quantity of drones made in this yeah\n" + "Type the year you want \n");
                    year2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In this year was made " + droneRepository.GetQuantityOfMadeThisYear(year2) + " drones");
                    int year3;
                    Console.WriteLine("Show quantity of robots made in this yeah\n" + "Type the year you want \n");
                    year3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In this year was made " + droneRepository.GetQuantityOfMadeThisYear(year3) + " robots");
                    break;
                case "*":
                    string brand, model, year, price, quantity;

                    Console.WriteLine("Brand:");
                    brand = Console.ReadLine();
                    Console.WriteLine("Model:");
                    model = Console.ReadLine();
                    Console.WriteLine("Year:");
                    year = Console.ReadLine();
                    Console.WriteLine("Price:");
                    price = Console.ReadLine();
                    Console.WriteLine("Quantity:");
                    quantity = Console.ReadLine();
                    droneRepository.Add(new Drone
                    {
                        Brand = brand,
                        Model = model,
                        Year = Convert.ToInt32(year),
                        Price = Convert.ToInt32(price),
                        Quantity = Convert.ToInt32(quantity)
                    });
                    Console.WriteLine("Drone added!");
                    break;
                case "0":
                    break;
                default:
                    throw new MyException(MyExceptionKind.WrongUserInputExeption, "\nError : Error try again\n");
                    break;
            }
        }
    }
}
