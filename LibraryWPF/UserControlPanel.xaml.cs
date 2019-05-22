using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for UserControlPanel.xaml
    /// </summary>
    public partial class UserControlPanel : Window
    {
        LibraryEntities db;
        public UserControlPanel()
        {
            InitializeComponent();
            db = new LibraryEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.User.Load();
            db.RentedBooksInfo.Load();

            List<String> categories = new List<String> { "All", "Lastname", "Telephone", "Address", "E-mail"};
            CriteriumCombobox.ItemsSource = categories;
            UsersGrid.ItemsSource = db.User.Local.ToBindingList();

            this.Closing += Window_Closing;
        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)//otsing
        {
            if(CriteriumCombobox.SelectedValue.ToString().Equals("All"))
            {
                UsersGrid.ItemsSource = db.User.Local.ToBindingList();
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Lastname"))
            {
                var searching = db.User.Where(t => t.Lastname.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    UsersGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Telephone"))
            {
                var searching = db.User.Where(t => t.Telephone.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    UsersGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Address"))
            {
                var searching = db.User.Where(t => t.Address.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    UsersGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("E-mail"))
            {
                var searching = db.User.Where(t => t.E_mail.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    UsersGrid.ItemsSource = searching;
                }
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)//redigeerimine
        {
            if (UsersGrid.SelectedItems != null)
            {
                for (int i = 0; i < UsersGrid.SelectedItems.Count; i++)
                {
                    User user = UsersGrid.SelectedItems[i] as User;
                    if (user != null)
                    {
                       TValues.userid = user.UserId;
                    }
                }
            }
            TValues.edit_type = "user";
            Edit r = new Edit();
            r.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void UsersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsersGrid.SelectedItems != null)
            {
                for (int i = 0; i < UsersGrid.SelectedItems.Count; i++)
                {
                    User user = UsersGrid.SelectedItems[i] as User;
                    if (user != null)
                    {
                        var g = db.RentedBooksInfo.
                       Where(t => t.User_Id == user.UserId).ToList();
                        RentingHistoryGrid.ItemsSource = g;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminBooks ab = new AdminBooks();
            ab.Show();
            this.Close();
        }
    }
}
