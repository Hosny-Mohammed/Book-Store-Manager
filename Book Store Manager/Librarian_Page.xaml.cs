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
    /// Interaction logic for Librarian_Page.xaml
    /// </summary>
    public partial class Librarian_Page : Page
    {
        public Librarian_Page(string name)
        {
            InitializeComponent();
            name_label.Content = $"Welcome {name}";
        }

        private void Add_Book(object sender, RoutedEventArgs e)
        {

        }

        private void Remove_Book(object sender, RoutedEventArgs e)
        {

        }
    }
}
