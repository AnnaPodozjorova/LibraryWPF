using System;
using System.Collections;
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
using System.Windows.Threading;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for UserBooks.xaml
    /// </summary>
    public partial class UserBooks : Window
    {

        LibraryEntities db;
        public static int userid;

        public UserBooks()
        {
            InitializeComponent();

            db = new LibraryEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Book.Load();
            db.User.Load();
            db.RentedBooksInfo.Load();

            BooksDataGrid.ItemsSource = db.Book.Local.ToBindingList();

            //n4itab useri laenatud raamatuid
            var g = db.RentedBooksInfo.
                      Where(t => t.UserId == SignUp.userid).ToList();
            RentedBooksGrid.ItemsSource = g;

            //kui raamatu tagastamise aeg on l4bi, siis nuppud "Return" ja "Rent" pole aktiivsed
            var fine = new List<double>();

            if (g != null)
            {
                foreach (RentedBooksInfo r in g)
                {
                    if (r.Return_date < DateTime.Now)
                    {
                        foreach (User u in db.User.Local.ToBindingList())
                        {
                            if (u.UserId == SignUp.userid)
                            {
                                fine.Clear();
                                IQueryable<Rent> RB = db.Rent.Where(p => p.User_Id == u.UserId && p.Return_date < DateTime.Now);
                                foreach (Rent m in RB)
                                {
                                    m.Status = "Not paid";
                                    if (u.UserId == r.User_Id && r.Status == "Not paid")
                                    { fine.Add((DateTime.Now - r.Return_date).TotalDays * 0.14); }
                                }

                                u.ToPay = String.Format("{0:0.##}", fine.Sum());
                                MessageBox.Show("Rental time is out. Pay " + u.ToPay + "$", "Error",
                                      MessageBoxButton.OK, MessageBoxImage.Information);


                                RentBtn.IsEnabled = false;
                                ReturnBtn.IsEnabled = false;

                            }
                        }
                        break;

                    }
                    else
                    {
                        RentBtn.IsEnabled = true;
                        ReturnBtn.IsEnabled = true;
                    }

                }
            }

            //combobox kategooriad
            List<String> categories = new List<String> { "All", "ID", "Title", "Author", "Description", "Genre", "Notes" };
            CriteriumCombobox.ItemsSource = categories;
            /* List<String> Genres = db.Book.AsEnumerable()
                           .Select(row => row.Genre.ToString())
                           .ToList();
             CriteriumCombobox.ItemsSource = Genres;*/
            db.SaveChanges();
            this.Closing += UserBooks_Closing;

        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)//otsing
        {
            if (CriteriumCombobox.SelectedValue.ToString().Equals("ID"))
            {
                int id = Int32.Parse(SearchBox.Text);
                var searching = db.Book.Where(t => t.BookId == id).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("All"))
            {
                BooksDataGrid.ItemsSource = db.Book.Local.ToBindingList();
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Title"))
            {
                var searching = db.Book.Where(t => t.Title.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Author"))
            {
                var searching = db.Book.Where(t => t.Author.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Description"))
            {
                var searching = db.Book.Where(t => t.Description.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Genre"))
            {
                var searching = db.Book.Where(t => t.Genre.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Notes"))
            {
                var searching = db.Book.Where(t => t.Notes.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }


            BooksDataGrid.Items.Refresh();
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)//profiili nupp
        {
            Profile p = new Profile();
            p.Show();


        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)//logi v4lja
        {
            SignUp login = new SignUp();
            login.Show();
            this.Close();
        }

        private void RentBtn_Click(object sender, RoutedEventArgs e)//rent nupp
        {
            if (BooksDataGrid.SelectedItems != null)
            {
                for (int i = 0; i < BooksDataGrid.SelectedItems.Count; i++)
                {

                    Book book = BooksDataGrid.SelectedItems[i] as Book;
                    if (book != null && book.Quantity != 0)//raamatute kogus peab olema suurem kui null
                    {

                        Rent r = new Rent();
                        if (db.Rent.Local.ToBindingList() == null)
                        {
                            r.RentId = 1;
                        }
                        else
                        {
                            r.RentId = db.Rent.Max(k => k.RentId) + 1;
                        }
                        r.Book_Id = book.BookId;
                        r.User_Id = SignUp.userid;
                        r.Rent_date = DateTime.Now;
                        r.Return_date = DateTime.Now.AddDays(21);
                        r.Status = "Rented";

                        Book b = (from p in db.Book
                                  where p.BookId == book.BookId
                                  select p).SingleOrDefault();
                        b.Quantity--;

                        db.Rent.Add(r);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Quantity is 0.", "Error",
    MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }

            LibraryEntities db2 = new LibraryEntities();
            db2.Book.Load();
            db2.RentedBooksInfo.Load();
            BooksDataGrid.ItemsSource = null;
            RentedBooksGrid.ItemsSource = null;
            BooksDataGrid.ItemsSource = db2.Book.Local.ToBindingList();

            var g = db2.RentedBooksInfo.
                      Where(t => t.UserId == SignUp.userid).ToList();
            RentedBooksGrid.ItemsSource = g;
            db2.Dispose();

        }


        private void ReturnBtn_Click(object sender, RoutedEventArgs e)//return nupp
        {
            RentInfoTextBlock.Text = String.Empty;
            if (RentedBooksGrid.SelectedItems != null)
            {
                for (int i = 0; i < RentedBooksGrid.SelectedItems.Count; i++)
                {

                    RentedBooksInfo rbook = RentedBooksGrid.SelectedItems[i] as RentedBooksInfo;
                    if (rbook != null)
                    {

                        Rent r = (from p in db.Rent
                                  where p.Book_Id == rbook.BookId &&
                                  p.User_Id == rbook.User_Id &&
                                  p.RentId == rbook.RentId
                                  select p).SingleOrDefault();

                        Book b = (from p in db.Book
                                  where p.BookId == rbook.BookId
                                  select p).SingleOrDefault();
                        b.Quantity++;
                        db.Rent.Remove(r);
                        db.SaveChanges();
                    }
                }
            }

            LibraryEntities db2 = new LibraryEntities();
            db2.Book.Load();
            db2.RentedBooksInfo.Load();
            BooksDataGrid.ItemsSource = null;
            RentedBooksGrid.ItemsSource = null;
            BooksDataGrid.ItemsSource = db2.Book.Local.ToBindingList();
            var g = db2.RentedBooksInfo.
                      Where(t => t.UserId == SignUp.userid).ToList();
            RentedBooksGrid.ItemsSource = g;
            db2.Dispose();

        }

        private void RentedBooksGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)//laenatud raamatu info
        {
            if (RentedBooksGrid.SelectedItems != null)
            {
                for (int i = 0; i < RentedBooksGrid.SelectedItems.Count; i++)
                {
                    RentedBooksInfo info = RentedBooksGrid.SelectedItems[i] as RentedBooksInfo;
                    if (info != null)
                    {
                        var g = db.RentedBooksInfo.
                      Where(t => t.BookId == info.Book_Id).ToList();
                        foreach (RentedBooksInfo r in g)
                        {
                            RentInfoTextBlock.Text = "Return Date: " + r.Return_date + "\r\nRent Date: "
                                  + r.Rent_date + "\r\nStatus: " + r.Status;
                            Calendar.SelectedDate = r.Return_date;

                        }
                    }
                }
            }


        }

        private void UserBooks_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

    }
}
