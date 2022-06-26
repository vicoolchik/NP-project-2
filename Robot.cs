using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
	public class Robot : IMachinery
	{
		private string brand;
		private string function;
		private int year;
		private int price;
		private int quantity;
		public Robot(string brand = "", string function = "", int year = 0, int price = 0, int quantity = 0)
		{
			this.Brand = brand;
			this.Function = function;
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
			return Brand + " " + Function + " " + Year.ToString() + " " + Price.ToString() + " " + Quantity.ToString();
		}
		public string StringToFile()
		{
			return Brand + "," + Function + "," + Year.ToString() + "," + Price.ToString() + "," + Quantity.ToString() + ",\n";
		}

		public string Brand { get; set; }
		public string Function { get; set; }
		public int Year { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
		public static bool operator ==(Robot robot1, Robot robot2)
		{
			return (robot1.brand == robot2.brand &&
				robot1.function == robot2.function && robot1.year == robot2.year && robot1.price == robot2.price && robot1.quantity == robot2.quantity);
		}
		public static bool operator !=(Robot robot1, Robot robot2)
		{
			return !(robot1 == robot2);
		}
		public static bool operator <(Robot robot1, Robot robot2)
		{
			bool status = false;

			if (robot1.quantity < robot2.quantity)
			{
				status = true;
			}
			return status;
		}
		public static bool operator >(Robot robot1, Robot robot2)
		{
			bool status = false;

			if (robot1.quantity > robot2.quantity)
			{
				status = true;
			}
			return status;
		}
	}
}
