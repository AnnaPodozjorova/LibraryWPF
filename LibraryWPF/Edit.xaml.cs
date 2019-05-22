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
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class Edit : Window
    {
        LibraryEntities db;
        public Edit()
        {
            InitializeComponent();
            db = new LibraryEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Book.Load();
            db.User.Load();
            db.RentedBooksInfo.Load();

            if (TValues.edit_type.Equals("user"))//kategooriad useri jaoks
            {
                List<String> categories = new List<String> { "Firstname", "Lastname", "Telephone", "Address", "E-mail", "Type", "Fine" };
                CriteriumCombobox.ItemsSource = categories;
            }
            else if (TValues.edit_type.Equals("book"))//kategooriad raamatu jaoks
            {
                List<String> categories = new List<String> { "Title", "Author", "Description", "Shelf", "Genre", "Quantity", "Price", "Notes" };
                CriteriumCombobox.ItemsSource = categories;
            }
            this.Closing += Window_Closing;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)//andmete db' muutmine
        {
            //useri andmete redigeerimine
            if (TValues.edit_type.Equals("user"))
            {
                if (CriteriumCombobox.SelectedValue.ToString().Equals("Firstname"))
                {
                    User b = (from p in db.User
                              where p.UserId == TValues.userid
                              select p).SingleOrDefault();
                    b.Firstname = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Lastname"))
                {
                    User b = (from p in db.User
                              where p.UserId == TValues.userid
                              select p).SingleOrDefault();
                    b.Lastname = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Telephone"))
                {
                    User b = (from p in db.User
                              where p.UserId == TValues.userid
                              select p).SingleOrDefault();
                    b.Telephone = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Address"))
                {
                    User b = (from p in db.User
                              where p.UserId == TValues.userid
                              select p).SingleOrDefault();
                    b.Address = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("E-mail"))
                {
                    User b = (from p in db.User
                              where p.UserId == TValues.userid
                              select p).SingleOrDefault();
                    b.E_mail = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Fine"))
                {
                    User b = (from p in db.User
                              where p.UserId == TValues.userid
                              select p).SingleOrDefault();
                    b.ToPay = newvaluefield.Text;

                    db.Rent.RemoveRange(db.Rent.Where(c => c.User_Id == TValues.userid && c.Status.Equals("Not paid")));

                  /*  Rent j = (from p in db.Rent
                              where p.User_Id == TValues.userid && p.Status.Equals("Not paid")
                              select p).SingleOrDefault();
                    db.Rent.Remove(j);*/
                }
            }
            //raamatu andmete redigeerimine
            else if (TValues.edit_type.Equals("book"))
            {
                if (CriteriumCombobox.SelectedValue.ToString().Equals("Title"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Title = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Author"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Author = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Description"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Description = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Shelf"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Shelf = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Genre"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Genre = newvaluefield.Text;
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Quantity"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Quantity = Int32.Parse(newvaluefield.Text);
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Price"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Price = System.Convert.ToDecimal(newvaluefield.Text);
                }
                else if (CriteriumCombobox.SelectedValue.ToString().Equals("Notes"))
                {
                    Book b = (from p in db.Book
                              where p.BookId == TValues.bookid
                              select p).SingleOrDefault();
                    b.Notes = newvaluefield.Text;
                }
            }

            db.SaveChanges();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)//paneb aknat kinni
        {
            if (TValues.edit_type.Equals("user"))
            {
                UserControlPanel i = new UserControlPanel();
                i.Show();
                this.Close();
            }
            else if (TValues.edit_type.Equals("book"))
            {
                AdminBooks i = new AdminBooks();
                i.Show();
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
    }
}
