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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        LibraryEntities db;
        public AddBook()
        {
            InitializeComponent();
            db = new LibraryEntities();//andmebaas
            db.Configuration.ProxyCreationEnabled = false;
            db.Book.Load();//raamatud

            this.Closing += Window_Closing;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)//nupp "Add"
        {
            if (!string.IsNullOrWhiteSpace(AuthorBox.Text) && !string.IsNullOrWhiteSpace(descbox.Text) && !string.IsNullOrWhiteSpace(genrebox.Text) 
                && !string.IsNullOrWhiteSpace(NoteBox.ToString()) && !string.IsNullOrWhiteSpace(Pricebox.Text) && !string.IsNullOrWhiteSpace(quantitybox.Text) 
                && !string.IsNullOrWhiteSpace(shelfbox.Text) && !string.IsNullOrWhiteSpace(titlebox.Text))//kontrollib, kas v4ljad on t4idetud
            {
                //uue raamatu andmete lisamine
                Book b = new Book();
            b.BookId= db.Book.Max(k => k.BookId) + 1;
            b.Author = AuthorBox.Text;
            b.Description = descbox.Text;
            b.Genre = genrebox.Text;
            b.Notes = NoteBox.Text;
            b.Price = System.Convert.ToDecimal(Pricebox.Text);
            b.Quantity = Int32.Parse(quantitybox.Text);
            b.Shelf = shelfbox.Text;
            b.Title = titlebox.Text;
            db.Book.Add(b);
            db.SaveChanges();

            }
            else //kui on tyhjad v4ljad
            {
                //error message
                MessageBox.Show("All fields have to be filled.", "Empty field",
     MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)//nupp "Cancel"
        {
            //tagasi "AdminBooks" aknasse
            AdminBooks ab = new AdminBooks();
            ab.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
    }
}
