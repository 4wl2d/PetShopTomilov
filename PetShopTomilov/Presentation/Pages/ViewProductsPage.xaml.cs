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

namespace PetShopTomilov.Pages
{
    /// <summary>
    /// Interaction logic for ViewProductsPage.xaml
    /// </summary>
    public partial class ViewProductsPage : Page
    {
        public ViewProductsPage()
        {
            InitializeComponent();

            ProductListView.ItemsSource = Data.PetShopEntities.getContext().Product.ToList();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SortUpRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SortDownRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
