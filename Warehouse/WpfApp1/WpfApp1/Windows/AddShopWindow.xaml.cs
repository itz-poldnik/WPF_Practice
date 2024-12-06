using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Classes;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddShopWindow.xaml
    /// </summary>
    public partial class AddShopWindow : Window
    {
        private Shop _currentShop = new Shop();
        public AddShopWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveShop_Click(object sender, RoutedEventArgs e)
        {
            using (WarehouseContext context = new WarehouseContext())
            {
                _currentShop.Name = txtname.Text;
                _currentShop.Address = txtaddress.Text;
                _currentShop.Phone = txtphone.Text;
                if (_currentShop.IdShop == 0)
                {
                    context.Shops.Add(_currentShop);
                    context.SaveChanges();
                    MessageBox.Show("Новый магазин успешно добавлен");
                }
                else
                {
                    context.Shops.Update(_currentShop);
                }
            }
            ShopWindow shopwindow = new ShopWindow();
            shopwindow.Show();
            this.Close();
        }

        private void BtnBacksShop_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopwindow = new ShopWindow();
            shopwindow.Show();
            this.Close();
        }
    }
}
