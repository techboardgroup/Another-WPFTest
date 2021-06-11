using CRUD_WPF.Models;
using CRUD_WPF.Pages;
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

namespace CRUD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

		public MainWindow()
        {
            InitializeComponent();
			// lbUsers.ItemsSource = users;
		}

        private void Tab_Change(object sender, SelectionChangedEventArgs e)
        {
        }

        //private void btnAddUser_Click(object sender, RoutedEventArgs e)
        //{
        //	users.Add(new User() { Name = "New user" });
        //}

        //private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        //{
        //	if (lbUsers.SelectedItem != null)
        //		(lbUsers.SelectedItem as User).Name = "Random Name";
        //}

        //private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        //{
        //	if (lbUsers.SelectedItem != null)
        //		users.Remove(lbUsers.SelectedItem as User);
        //}
    }
}
