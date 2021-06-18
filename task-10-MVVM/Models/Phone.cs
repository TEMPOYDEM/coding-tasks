using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBindingExample
{
    public class Phone : INotifyPropertyChanged	//важно унаследовать интерфейс для работы с байндингами
    {
		//внутренние скрытые поля
		private string _name;
		private int _price;
		private int _phonenumber;
		//внешнее поле с именем
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (_name != value)
				{
					_name = value;
					//вызываем функцию, которая сообщает об обновлении поля Name
					this.NotifyPropertyChanged("Name");
				}
			}
		}

		//внешнее поле с ценой
		public int Price
		{
			get
			{
				return _price;
			}
			set
			{
				if (_price != value)
				{
					bool Changed = int.TryParse(value.ToString(), out _price);
					//вызываем функцию, которая сообщает об обновлении поля Price
					if (Changed) this.NotifyPropertyChanged("Price");
				}
			}
		}
		public int Phonenumber
		{
			get
			{
				return _phonenumber;
			}
			set
			{
				if (_phonenumber != value)
				{
					bool Changed = int.TryParse(value.ToString(), out _phonenumber);
					//вызываем функцию, которая сообщает об обновлении поля Price
					if (Changed) this.NotifyPropertyChanged("Phonenumber");
				}
			}
		}
		//пустой конструктор класса
		public Phone() { }

		//конструктор класса для заполнения при создании объекта
		public Phone(string Name, int Price, int Phonenumber)
        {
			this.Name = Name;
			this.Price = Price;
			this.Phonenumber = Phonenumber;
        }

		//событие, которое срабатывает при обновлении объекта
		public event PropertyChangedEventHandler PropertyChanged;

		//функция, которую надо запустить, чтобы сообщить об обновлении объекта
		public void NotifyPropertyChanged(string propName)
		{
			if (this.PropertyChanged != null) 
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
	}
}
