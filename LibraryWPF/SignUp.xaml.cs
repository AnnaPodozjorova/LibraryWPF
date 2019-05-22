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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public static int userid;
        LibraryEntities db;
        public SignUp()
        {
            InitializeComponent();
            db = new LibraryEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.User.Load();
        }

        private void Regbutton_Click(object sender, RoutedEventArgs e)//registratsiooni nupp
        {
            Registration r = new Registration();
            r.Show();
            this.Close();
        }

        private void SignUpbutton_Click(object sender, RoutedEventArgs e)//systeemi sisse logimine ja kasutaja tyypi m44ramine
        {
            Boolean msgbox = false;
            //fields have to be filled
            if (!string.IsNullOrWhiteSpace(EmailTxtbox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Password.ToString()))
            {
                foreach (User u in db.User.ToList())
                {
                    if (u.E_mail.Equals(EmailTxtbox.Text) && u.Password.Equals(PasswordBox.Password.ToString()))
                    {
                        userid = u.UserId;
                        if (u.Type == 0)
                        {
                            msgbox = false;
                            AdminBooks admin = new AdminBooks();
                            admin.Show();
                            this.Close();
                            break;
                        }
                        else if (u.Type == 1)
                        {
                            msgbox = false;
                            UserBooks user = new UserBooks();
                            user.Show();
                            this.Close();
                            break;
                        }
                    }
                    else
                    {
                        msgbox = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields have to be filled.", "Empty field",
     MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (msgbox == true)
            {
                MessageBox.Show("Wrong e-mail or password.", "Error",
          MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }

}
