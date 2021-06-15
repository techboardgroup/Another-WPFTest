using Aspose.Cells.Drawing;
using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for Assignment.xaml
    /// </summary>
    public partial class Assignment : Page
    {
        private ObservableCollection<Models.Ticket> ticket = new ObservableCollection<Models.Ticket>();
        private ObservableCollection<Models.Assignment> assignment = new ObservableCollection<Models.Assignment>();
        private ObservableCollection<Models.User> user = new ObservableCollection<Models.User>();
        private Models.Ticket selectedTicket;

        public Assignment()
        {
            InitializeComponent();
            user.Add(new Models.User()
            {
                Category = "test",
                Email = "pippo@pluto.com",
                Name = "pippo"
            });
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.Current != null && App.Current.Properties != null && App.Current.Properties["ticket"] != null)
            {
                ticket = (ObservableCollection<Models.Ticket>)App.Current.Properties["ticket"];
                lbTicket.ItemsSource = ticket;
            }
        }

        private void lbTicket_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if ( lbTicket != null && lbTicket.SelectedItem != null)
                selectedTicket = (Models.Ticket)lbTicket.SelectedItem;

            dlgAssign.IsOpen = true;
            comboUsers.Items.Clear();
            foreach (Models.User singleUser in user)
            {
                comboUsers.Items.Add(singleUser.Email);
            }

        }

        private void ButtonSaveDialog_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
        }
    }
}
