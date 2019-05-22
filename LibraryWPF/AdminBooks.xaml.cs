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
    /// Interaction logic for AdminBooks.xaml
    /// </summary>
    public partial class AdminBooks : Window
    {
        LibraryEntities db;
        public static int booksdataid;//selekteeritud raamatu id
        public AdminBooks()
        {
            InitializeComponent();
            db = new LibraryEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Book.Load();

            //raamatute andmete datagridisse 
            BooksDataGrid.ItemsSource = db.Book.Local.ToBindingList();

            //combobox kategooriad
            List<String> categories = new List<String> { "All", "ID", "Title", "Author", "Description", "Shelf", "Genre", "Notes" };
            CriteriumCombobox.ItemsSource = categories;

            //trahvi v4lja arvutamine
            var users = db.User;
            var rents = db.Rent;
            var fine = new List<double>();
            foreach (User u in users)
            {
                foreach(Rent r in rents)
                {
                    if(r.User_Id==u.UserId)
                    {
                        if(r.Return_date < DateTime.Now)
                        {
                            fine.Clear();
                            IQueryable<Rent> RB = db.Rent.Where(p => p.User_Id == u.UserId && p.Return_date < DateTime.Now);
                            foreach (Rent m in RB)
                            {
                                m.Status = "Not paid";
                                if (u.UserId == r.User_Id && r.Status == "Not paid")
                                { fine.Add((DateTime.Now - r.Return_date).TotalDays * 0.14); }
                            }
                            u.ToPay = String.Format("{0:0.##}", fine.Sum())+"$";
                        }
                    }
                }
            }




            db.SaveChanges();


            this.Closing += Window_Closing;

        }



        private void FindBtn_Click(object sender, RoutedEventArgs e)//otsing erineva kriteeriumi j4rgi
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
            else if (CriteriumCombobox.SelectedValue.ToString().Equals("Shelf"))
            {
                var searching = db.Book.Where(t => t.Shelf.Contains(SearchBox.Text)).ToList();
                if (searching != null)
                {
                    BooksDataGrid.ItemsSource = searching;
                }
            }


            BooksDataGrid.Items.Refresh();

        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)//avab useri profiili
        {
            Profile p = new Profile();
            p.Show();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)//v4lja logimine
        {
            SignUp s = new SignUp();
            s.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)//avab "Add" aknat
        {
            AddBook ab = new AddBook();
            ab.Show();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)//raamatu kustutamine 
        {
            if (BooksDataGrid.SelectedItems != null)
            {
                for (int i = 0; i < BooksDataGrid.SelectedItems.Count; i++)
                {

                    Book rbook = BooksDataGrid.SelectedItems[i] as Book;
                    if (rbook != null)
                    {
                        Book b = (from p in db.Book
                                  where p.BookId == rbook.BookId
                                  select p).SingleOrDefault();
                        db.Book.Remove(b);
                    }
                }
            }
            db.SaveChanges();
            db.Book.Load();
            BooksDataGrid.Items.Refresh();

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)//raamatu andmete redigeerimine
        {
            if (BooksDataGrid.SelectedItems != null)
            {
                for (int i = 0; i < BooksDataGrid.SelectedItems.Count; i++)
                {
                    Book b = BooksDataGrid.SelectedItems[i] as Book;
                    if (b != null)
                    {
                        TValues.bookid = b.BookId;
                    }
                }
            }
            TValues.edit_type = "book";
            Edit n = new Edit();
            n.Show();
            this.Close();
        }

        private void UserControlPanelBtn_Click(object sender, RoutedEventArgs e)//avab "User control panel" aknat
        {
            UserControlPanel ucp = new UserControlPanel();
            ucp.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void BooksDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)//selekteeritud raamatu id saamine
        {
            if (BooksDataGrid.SelectedItems != null)
            {
                for (int i = 0; i < BooksDataGrid.SelectedItems.Count; i++)
                {

                    Book book = BooksDataGrid.SelectedItems[i] as Book;
                    if (book != null)
                    {
                        booksdataid = book.BookId;

                    }
                }
            }
        }
    }
}
