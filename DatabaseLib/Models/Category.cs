using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Models
{
    public class Category : INotifyPropertyChanged
	{
		private int _id; 

		private string _name;

		private string _group;

		public event PropertyChangedEventHandler PropertyChanged;


		[PrimaryKey, AutoIncrement]
		[Column("id")]
		public int Id
		{
			get { return this._id; }
			set
			{
				if (this._id != value)
				{
                    this._id = value;
					this.NotifyPropertyChanged("Id");
				}
			}
		}

		[Column("name")]
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

		[Column("group")]
		public string Group
		{
			get { return this._group; }
			set
			{
				if (this._group != value)
				{
					this._group = value;
					this.NotifyPropertyChanged("Group");
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
