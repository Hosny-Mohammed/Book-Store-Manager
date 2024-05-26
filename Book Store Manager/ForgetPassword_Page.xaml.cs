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
    /// Interaction logic for ForgetPassword_Page.xaml
    /// </summary>
    public partial class ForgetPassword_Page : Page
    {
        BookStoreDBEntities DB = new BookStoreDBEntities();
        PasswordValidation passwordValidation = new PasswordValidation();
        public ForgetPassword_Page()
        {
            InitializeComponent();
        }

        private void Update_btn_Click(object sender, object e)
        {
            if (Username_txt.Text == "" || Password_txt.Password == "")
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
                            var librarain = DB.Librarians.FirstOrDefault(x => x.Username == Username_txt.Text);
                            if (librarain == null)
                            {
                                MessageBox.Show("This User Is not found", "Error");
                            }
                            else
                            {
                                librarain.Password = Password_txt.Password;
                                DB.Librarians.AddOrUpdate(librarain);
                                DB.SaveChanges();
                                MessageBox.Show("The password Is updated", "Message");
                                this.NavigationService.GoBack();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error");
                        }
                    }
                    else if (ComboBox.SelectedIndex == 1)
                    {
                        
                        try
                        {
                            //check there's any user using this user name
                            var user = DB.Users.FirstOrDefault(x => x.Username == Username_txt.Text);
                            if (user == null)
                                MessageBox.Show("This User Is not found", "Error");
                            else
                            {
                                user.Password = Password_txt.Password;
                                DB.Users.AddOrUpdate(user);
                                DB.SaveChanges();
                                MessageBox.Show("The password Is updated", "Message");
                                this.NavigationService.GoBack();
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error");
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
