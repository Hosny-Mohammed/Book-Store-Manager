using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Book_Store_Manager
{
    /// <summary>
    /// Interaction logic for Librarian_Page.xaml
    /// </summary>
    public partial class Librarian_Page : Page
    {
        BookStoreDBEntities1 DB = new BookStoreDBEntities1();

        private IQueryable<dynamic> Borrower()
        {
            var query = from b in DB.Borrowing_Books
                        join k in DB.Users on b.UserID equals k.UserID
                        join z in DB.Books on b.BookID equals z.BookID
                        select new
                        {
                            k.Name,
                            z.Title,
                            b.Date,
                            b.End_Date
                        };
            return query;
        }

        public Librarian_Page(string name)
        {
            InitializeComponent();
            name_label.Content = $"Welcome {name}";
            Books_DataGrid.ItemsSource = DB.Books.ToList();
            Borrower_Details.ItemsSource = Borrower().ToList();
        }

        

        private void Add_Book(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            if(Title_txt.Text == "" || Auther_txt.Text == "" || ISBN_txt.Text == ""|| Price_txt.Text == "" || Quantity_txt.Text == "")
            {
                MessageBox.Show("You Should Fill All The Fields" , "Error");
            }
            else
            {
                try
                {
                    book.Title = Title_txt.Text;
                    book.Author = Auther_txt.Text;
                    book.ISBN = ISBN_txt.Text;
                    decimal price = Convert.ToDecimal(Price_txt.Text);
                    book.Price = price;
                    int quantity = Convert.ToInt32(Quantity_txt.Text);
                    book.Quantity = quantity;
                    DB.Books.AddOrUpdate(book);
                    DB.SaveChanges();
                    MessageBox.Show("It's Added Successfully", "Message");
                    Books_DataGrid.ItemsSource = DB.Books.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void Remove_Book(object sender, RoutedEventArgs e)
        {
            if(ID_txt.Text == "")
            {
                MessageBox.Show("You Should Fill ID's Field To Remove", "Error");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(ID_txt.Text);
                    var book = DB.Books.Find(id);
                    if (book != null) 
                    {
                        DB.Books.Remove(book);
                        DB.SaveChanges();
                        MessageBox.Show("It's Removed Successfully", "Message");
                        Books_DataGrid.ItemsSource = DB.Books.ToList();
                    }
                    else
                    {
                        MessageBox.Show("This ID Not Found", "Error");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
            }
        }
    }
}
