using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WPF.Models
{
	public class Ticket : INotifyPropertyChanged
	{
		private string _name;

		private DateTime _date;

		private string _category;

		private string _description;

		public string Name
		{
			get { return this._name; }
			set
			{
				if (this._name != value)
				{
					this._name = value;
					this.NotifyPropertyChanged("Name");
				}
			}
		}

		public DateTime Date
		{
			get { return this._date; }
			set
			{
				if (this._date != value)
				{
					this._date = value;
					this.NotifyPropertyChanged("Date");
				}
			}
		}

		public string Category
		{
			get { return this._category; }
			set
			{
				if (this._category != value)
				{
					this._category = value;
					this.NotifyPropertyChanged("Category");
				}
			}
		}

		public string Description
		{
			get { return this._description; }
			set
			{
				if (this._description != value)
				{
					this._description = value;
					this.NotifyPropertyChanged("Description");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}
}
