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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        LibraryEntities db;
        public Profile()
        {
            InitializeComponent();
            db = new LibraryEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.User.Load();

            foreach (User u in db.User.ToList())//n4itab useri andmeid
            {
                if(u.UserId==SignUp.userid)
                {
                    namelbl.Content = u.Firstname + " " + u.Lastname;
                    emaillbl.Content = u.E_mail;
                    pnumberlbl.Content = u.Telephone;
                    addresslbl.Content = u.Address;
                    if(u.Type==0)
                    {
                        ToPay.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                    replbl.Content = u.ToPay + "$";
                    }
                }
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
