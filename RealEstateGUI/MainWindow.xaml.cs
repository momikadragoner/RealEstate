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
using RealEstateGUI.Models;

namespace RealEstateGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ingatlanContext context = new ingatlanContext();
        public MainWindow()
        {
            InitializeComponent();
            List<Seller> sellers =  context.Sellers.ToList();
            LB_Seller.ItemsSource = sellers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LBL_adCount.Content = context.Realestates.Where(x => x.Seller.Name == ((Seller)LB_Seller.SelectedItem).Name).Count();
        }
    }
}
