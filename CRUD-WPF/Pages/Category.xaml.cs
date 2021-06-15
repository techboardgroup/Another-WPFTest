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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : Page
    {

        private ObservableCollection<Models.Category> category = new ObservableCollection<Models.Category>();

        public Category()
        {
            InitializeComponent();
            lbCategory.ItemsSource = category;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // DatabaseLib.Models.Category cat = new DatabaseLib.Models.Category();
            category.Add(new Models.Category() { Name = txtName.Text, Group = txtGroup.Text });
            App.Current.Properties["category"] = category;
            lbCategory.ItemsSource = category;
            txtGroup.Text = "";
            txtName.Text = "";
        }
    }
}
