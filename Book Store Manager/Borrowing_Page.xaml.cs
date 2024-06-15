using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for Borrowing_Page.xaml
    /// </summary>
    public partial class Borrowing_Page : Page
    {
        BookStoreDBEntities1 DB = new BookStoreDBEntities1();
        private List<Book> books_available(){
            List<Book> list = new List<Book>();
            foreach(Book b in DB.Books)
            {
                if(b.Quantity > 0)
                {
                    list.Add(b);
                }
            }
            return list;
        }

        private IQueryable<dynamic> Borrowing_Books(int ID)
        {
            IQueryable<dynamic> query = from b in DB.Borrowing_Books
                        where ID == b.UserID
                        join k in DB.Users on b.UserID equals k.UserID
                        join p in DB.Books on b.BookID equals p.BookID
                        where b.UserID == ID
                        select new
                        {
                            b.BookID,
                            p.Title,
                            b.End_Date,
                            b.UserID,
                            b.BorrowingID,
                            b.Date

                        };
            return query;
        }


        public Borrowing_Page(int ID)
        {
            InitializeComponent();

            available_Books_DG.ItemsSource = books_available();
            Borrowed_Books_DG.ItemsSource = Borrowing_Books(ID).ToList();

            name_label.Content = $"Welcome: {DB.Users.FirstOrDefault(x=>x.UserID ==  ID).Name}";
            ID_label.Content = $"ID: {ID}";
        }

        //Back Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (BookID_txt.Text == "")
            {
                MessageBox.Show("You Must Fill The data", "Error");
            }
            else
            {
                try
                {
                    int ID = int.Parse(BookID_txt.Text);

                    var n = DB.Borrowing_Books.FirstOrDefault(x => x.BorrowingID == ID);

                    if (n == null)
                        MessageBox.Show("You didn't Borrow This Book", "Message");
                    else
                    {
                        var book = DB.Books.FirstOrDefault(x => x.BookID == ID);
                        book.Quantity += 1;

                        DB.Borrowing_Books.Remove(n);
                        DB.Books.AddOrUpdate(book);
                        DB.SaveChanges();

                        Borrowed_Books_DG.ItemsSource = Borrowing_Books(n.UserID).ToList();

                        MessageBox.Show("You Back The Book", "Message");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
            }
        }

        private void Borrow_btn_Click(object sender, RoutedEventArgs e)
        {
            if (BookID_txt.Text == "" || UserID_txt.Text == "")
            {
                MessageBox.Show("You Must Fill The data", "Error");
            }
            else
            {
                try
                {
                    int Book_ID = int.Parse(BookID_txt.Text);
                    int User_ID = int.Parse(UserID_txt.Text);

                    var book = DB.Books.FirstOrDefault(x => x.BookID == Book_ID);
                    var IsBorrowing = DB.Borrowing_Books.FirstOrDefault(x => x.BookID == Book_ID);

                    if (IsBorrowing != null)
                        MessageBox.Show("You are already Borrowed This Book", "Message");
                    else
                    {
                        if(book == null)
                        {
                            MessageBox.Show("This Book Not Existed!", "Message");
                        }
                        else
                        {
                            book.Quantity -= 1;
                            DB.Books.AddOrUpdate(book);

                            Borrowing_Books bb = new Borrowing_Books();
                            bb.BookID = Book_ID;
                            bb.UserID = User_ID;
                            bb.Date = DateTime.Now;
                            bb.End_Date = DateTime.Now.AddDays(3);

                            DB.Borrowing_Books.Add(bb);

                            DB.Books.AddOrUpdate(book);
                            MessageBox.Show("You Borrowed The Book", "Message");
                            DB.SaveChanges();
                            Borrowed_Books_DG.ItemsSource = Borrowing_Books(User_ID).ToList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
            }
        }
    }
}
