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
using System.Windows.Shapes;
using WpfApp1.Classes;
using WpfApp1.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        WarehouseContext whContext = new WarehouseContext();
        public ShopWindow()
        {
            InitializeComponent();
            dtgShop.ItemsSource = whContext.Shops.ToList();

            cmbViewShop.ItemsSource = whContext.Shops.ToList();
            cmbViewShop.SelectedValuePath = "IdShop";
            cmbViewShop.DisplayMemberPath = "Address";
        }

        //private void BtnEditShop_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void rbUpShop_Click(object sender, RoutedEventArgs e)
        {
            dtgShop.ItemsSource = whContext.Shops.OrderBy(x=>x.Name).ToList();
        }

        private void rbDownShop_Click(object sender, RoutedEventArgs e)
        {
            dtgShop.ItemsSource = whContext.Shops.OrderByDescending(x=>x.Name).ToList();
        }

        private void txtSearchShop_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchShop.Text;
            dtgShop.ItemsSource = whContext.Shops.Where(x=>x.Name.Contains(searchText)).ToList();
        }

        private void cmbViewShop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Shop = int.Parse(cmbViewShop.SelectedValue.ToString());
            dtgShop.ItemsSource = whContext.Shops.Where(x=>x.IdShop == Shop).ToList();
        }

        private void btnAddShop_Click(object sender, RoutedEventArgs e)
        {
            AddShopWindow addshopwindow = new AddShopWindow();
            addshopwindow.Show();
            this.Close();
        }

        private void BtnDeleteShop_Click(object sender, RoutedEventArgs e)
        {
            var shopForRemoving = dtgShop.SelectedItems.Cast<Shop>().ToList();

            try
            {
                if (shopForRemoving.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {shopForRemoving.Count()} магазин?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        whContext.Shops.RemoveRange(shopForRemoving);
                    whContext.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgShop.ItemsSource = whContext.Shops.ToList();
                }
                else
                    MessageBox.Show("Данные не указаны", "Внимание", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные уже используются в других таблицах", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnBackShop_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
