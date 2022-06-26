using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
	public class Drone : IMachinery
	{
		private string brand;
		private string model;
		private int year;
		private int price;
		private int quantity;
		public Drone(string brand = "", string model = "", int year = 0, int price = 0, int quantity = 0)
		{
			this.Brand = brand;
			this.Model = model;
			if (year < 0 || year > 2021)
				throw new MyException(MyExceptionKind.WrongUserInputExeption, "\nError :Error try again\n");
			Year = year;
			if (price < 0)
				throw new MyException(MyExceptionKind.WrongUserInputExeption, "\nError :Error try again\n");
			Price = price;
			if (quantity < 0)
				throw new MyException(MyExceptionKind.WrongUserInputExeption, "\nError :Error try again\n");
			Quantity = quantity;

		}
		public override string ToString()
		{
			return Brand + " " + Model + " " + Year.ToString() + " " + Price.ToString() + " " + Quantity.ToString() + "\n";
		}
		public string StringToFile()
        {
			return Brand + "," + Model + "," + Year.ToString() + "," + Price.ToString() + "," + Quantity.ToString() + ",\n";
		}

		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }


		public static bool operator ==(Drone drone1, Drone drone2)
		{
			return (drone1.brand == drone2.brand &&
		drone1.model == drone2.model && drone1.year == drone2.year && drone1.price == drone2.price && drone1.quantity == drone2.quantity);
		}
		public static bool operator !=(Drone drone1, Drone drone2)
		{ return !(drone1 == drone2); }
		public static bool operator <(Drone drone1, Drone drone2)
		{
			bool status = false;

			if (drone1.quantity < drone2.quantity)
			{

				status = true;
			}
			return status;
		}
		public static bool operator >(Drone drone1, Drone drone2)
		{
			bool status = false;

			if (drone1.quantity > drone2.quantity)
			{
				status = true;
			}
			return status;
		}
	}
}

