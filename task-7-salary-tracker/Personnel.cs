using System;
using System.ComponentModel;

namespace Salary_tracker
{
	public class Personnel : INotifyPropertyChanged
	{
		private string Seller;
		public double Seller_sal
		{
			get
			{
				return _seller_sal
			}
			set
			{
				bool Changed = int.TryParse(value.ToString(), out _seller_sal);
				//вызываем функцию, которая сообщает об обновлении поля Price
				if (Changed) this.NotifyPropertyChanged("Seller_sal");
			}
		}
		private string Month_income
		public double Month
		{
			get
			{
				return _month_income

			}
			set
			{
				if (_month_income != value)
				{
					bool Changed = int.TryParse(value.ToString(), out _month_income);
					//вызываем функцию, которая сообщает об обновлении поля Price
					if (Changed) this.NotifyPropertyChanged("Month_income");
				}
			}
		}


		double Manager_sal = (Seller.Seller_sal) * (Seller.Seller_sal) * 0.25 * (Math.Pow(10, 4)) + Month_Income * 0.5 * Math.Pow(10, -2);

		double Driver_sal = Seller.Seller_sal * 0.85;		
	}
}