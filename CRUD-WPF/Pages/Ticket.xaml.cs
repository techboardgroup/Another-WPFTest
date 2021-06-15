using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUD_WPF.Pages
{
    /// <summary>
    /// Interaction logic for Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        private ObservableCollection<Models.Ticket> ticket = new ObservableCollection<Models.Ticket>();
        private ObservableCollection<Models.Category> categories = new ObservableCollection<Models.Category>();

        public Ticket()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtDeadline.SelectedDate = null;
            txtDescription.Text = "";
            txtName.Text = "";
            comboCategory.SelectedItem = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comboCategory.SelectedItem != null && txtDeadline.SelectedDate != null)
            {
                ticket.Add(new Models.Ticket()
                {
                    Category = (string)comboCategory.SelectedItem,
                    Deadline = (DateTime)txtDeadline.SelectedDate,
                    Description = txtDescription.Text,
                    Name = txtName.Text
                });
                App.Current.Properties["ticket"] = ticket;
                ClearForm();
            }
        }

        private void ComboBox_DropDownOpened(object sender, EventArgs e)
        {
            comboCategory.Items.Clear();
            if (App.Current != null && App.Current.Properties != null && App.Current.Properties["category"] != null)
            {
                categories = (ObservableCollection<Models.Category>)App.Current.Properties["category"];
                foreach(Models.Category singleCat in categories)
                {
                    comboCategory.Items.Add(singleCat.Name);
                }
            }
        }
    }
}
