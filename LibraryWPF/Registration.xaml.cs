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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        LibraryEntities db;
        public Registration()
        {
            InitializeComponent();
            db = new LibraryEntities();
            db.User.Load();
            this.Closing += Window_Closing;
        }

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {

            //fields have to be filled
            if (!string.IsNullOrWhiteSpace(fnamebox.Text) && !string.IsNullOrWhiteSpace(lnamebox.Text) && !string.IsNullOrWhiteSpace(emailbox.Text) && !string.IsNullOrWhiteSpace(passbox.Password.ToString()) && !string.IsNullOrWhiteSpace(addressbox.Text) && !string.IsNullOrWhiteSpace(telephonebox.Text))
            {
                //add inserted data to db
                User u = new User();
                u.UserId = db.User.Max(k => k.UserId) + 1;
                u.Firstname = fnamebox.Text;
                u.Lastname = lnamebox.Text;
                u.E_mail = emailbox.Text;
                u.Password = passbox.Password.ToString();
                u.Address = addressbox.Text;
                u.Type = 1;
                u.ToPay = 0+"$";
                u.Telephone = telephonebox.Text;

                db.User.Add(u);
                db.SaveChanges();
                SignUp f = new SignUp();
                f.Show();
                this.Close();
            }
            else
            {
                //error message
                MessageBox.Show("All fields have to be filled.", "Empty field",
     MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Close();
        }
    }
}
