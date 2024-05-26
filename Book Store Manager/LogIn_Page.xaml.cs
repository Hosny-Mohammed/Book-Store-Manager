using System;
using System.Collections.Generic;
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
    /// Interaction logic for LogIn_Page.xaml
    /// </summary>
    public partial class LogIn_Page : Page
    {
        BookStoreDBEntities DB = new BookStoreDBEntities();
        public LogIn_Page()
        {
            InitializeComponent();
        }
        // Sign Up Button

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp_Page page = new SignUp_Page();
            this.NavigationService.Navigate(page);
        }

        private void Forget_Pass_btn_Click(object sender, RoutedEventArgs e)
        {
            ForgetPassword_Page page = new ForgetPassword_Page();
            this.NavigationService.Navigate(page);
        }
        // Log in button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Password_txt.Password == "" || Username_txt.Text == "")
            {
                MessageBox.Show("You must Fill The data", "Error");
            }
            else
            {
                if (ComboBox.SelectedIndex == 0)
                {
                    var Librarian = DB.Librarians.FirstOrDefault(x => x.Username == Username_txt.Text);
                    if (Librarian != null && Librarian.Password == Password_txt.Password)
                    {
                        MessageBox.Show("Log In Successfully", "Message");

                        Librarian_Page page = new Librarian_Page(Librarian.Name);
                        this.NavigationService.Navigate(page);
                    }
                    else
                    {
                        MessageBox.Show("This User is not exist or password is wrong", "Error");
                    }
                }
                else if (ComboBox.SelectedIndex == 1) {
                    var user = DB.Users.FirstOrDefault(x => x.Username == Username_txt.Text);
                    if (user != null && user.Password == Password_txt.Password) {
                        MessageBox.Show("Log In Successfully", "Message");
                        Borrowing_Page page = new Borrowing_Page(user.UserID);
                        this.NavigationService.Navigate(page);
                    }
                    else
                    {
                        MessageBox.Show("This User is not exist or password is wrong", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("You Must Select an Item from the list", "Message");
                }

            }
        }
    }
}
