using System;
using System.ComponentModel;

namespace Personnel_
{
	public class Seller : INotifyPropertyChanged
	{
		private string Seller_sal;
		public double Seller
		{
			get
			{
				return Seller_sal
			}
			set
			{
				bool Changed = int.TryParse(value.ToString(), out Seller_sal);
				//вызываем функцию, которая сообщает об обновлении поля Price
				if (Changed) this.NotifyPropertyChanged("Seller_sal");
			}
		}
	}
	public class Main_Seller : INotifyPropertyChanged
	{
		private string Main_sal;
		public double Main_Seller()
		{
			get
			{

			}
			set
			{
				double Salary = (Seller.Salary) * (Seller.Salary) * 0.15 * (Math.Pow(10, 4)) + Month_Income * 0.1 * Math.Pow(10, -2)
		}
		}
	}
	public class Manager : INotifyPropertyChanged
	{
		private string Manager_sal;
		public double Manager()
		{
			get
			{

			}
			set
			{
				double Salary = (Seller.Salary) * (Seller.Salary) * 0.25 * (Math.Pow(10, 4)) + Month_Income * 0.5 * Math.Pow(10, -2)
		}
		}
	}
	public class Driver : INotifyPropertyChanged
	{
		private string Driver_sal;
		public double Driver()
		{
			get
			{

			}
			set
			{
				double Salary = Seller.Salary * 0.85
		}
		}
	}
}