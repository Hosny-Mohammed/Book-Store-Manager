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
using Book_Store_Manager;
namespace Book_Store_Manager
{
    /// <summary>
    /// Interaction logic for SignUp_Page.xaml
    /// </summary>
    public partial class SignUp_Page : Page
    {
        BookStoreDBEntities1 DB = new BookStoreDBEntities1();
        public SignUp_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PasswordValidation passwordValidation = new PasswordValidation();
            Librarian librarian = new Librarian();
            User user = new User();
            if (Name_txt.Text == "" || Password_txt.Password == "" || Username_txt.Text == "")
            {
                MessageBox.Show("You must Fill The data", "Error");
            }
            else
            {
                if (Password_txt.Password.Length >= 8 && passwordValidation.Validate(Password_txt.Password))
                {
                    if (ComboBox.SelectedIndex == 0)
                    {
                        try
                        {
                            //check there's any user using this user name
                            var Li = DB.Librarians.Where(x => x.Username == Username_txt.Text);
                            if(Li.Count() > 0)
                            {
                                MessageBox.Show("This User Is already existed", "Error");
                            }
                            else
                            {
                                librarian.Name = Name_txt.Text;
                                librarian.Username = Username_txt.Text;
                                librarian.Password = Password_txt.Password;
                                DB.Librarians.Add(librarian);
                                DB.SaveChanges();
                                MessageBox.Show("The User Is Created", "Message");
                                this.NavigationService.GoBack();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error");
                        }
                    } else if (ComboBox.SelectedIndex == 1)
                    {
                        //check there's any user using this user name
                        var use = DB.Users.Where(x => x.Username == Username_txt.Text); 
                        if (use.Count() > 0)
                        {
                            MessageBox.Show("This User Is already existed", "Error");
                        }
                        else
                        {
                            try
                            {
                                user.Name = Name_txt.Text;
                                user.Username = Username_txt.Text;
                                user.Password = Password_txt.Password;
                                DB.Users.Add(user);
                                DB.SaveChanges();
                                MessageBox.Show("The User Is Created", "Message");
                                this.NavigationService.GoBack();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"{ex.Message}", "Error");
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("You Must Select an Item from the list", "Message");
                    }
                }
                else
                {
                    MessageBox.Show("The Password Must Contain atleast one number,Upper case, lower case and Symbol", "Error");
                }
            }
        }
    }
}
