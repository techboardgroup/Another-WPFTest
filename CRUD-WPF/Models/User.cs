using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WPF.Models
{
    public class User : INotifyPropertyChanged
	{
		private string _email;

		private string _name;

		private string _category;

		public event PropertyChangedEventHandler PropertyChanged;

		public string Email
		{
			get { return this._email; }
			set
			{
				if (this._email != value)
				{
					this._email = value;
					this.NotifyPropertyChanged("Email");
				}
			}
		}

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

		public void NotifyPropertyChanged(string propName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}

    }
}
