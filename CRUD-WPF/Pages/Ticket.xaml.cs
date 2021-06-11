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
        private ObservableCollection<Models.Ticket> tickets = new ObservableCollection<Models.Ticket>();

        public Ticket()
        {
            InitializeComponent();
            tickets.Add(new Models.Ticket()
            {
                Category = "hello",
                Date = new DateTime(),
                Description = "ok",
                Name = "yes"
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void cmbCategory_DropDownOpened(object sender, EventArgs e)
        {
            ObservableCollection<Models.Category> category = (ObservableCollection<Models.Category>)App.Current.Properties["category"];
            //cmbCategory.Items = category;
        }
    }
}
