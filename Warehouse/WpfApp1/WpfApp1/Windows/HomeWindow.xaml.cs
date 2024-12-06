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
using WpfApp1.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void Button_product_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
            this.Close();
        }

        private void Button_supplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierWindow supplierWindow = new SupplierWindow();
            supplierWindow.Show();
            this.Close();
        }

        private void Button_shop_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();
            this.Close();
        }

        private void Button_invoice_Click(object sender, RoutedEventArgs e)
        {
            InvoiceWindow invoiceWindow = new InvoiceWindow();
            invoiceWindow.Show();
            this.Close();
        }

        private void Button_order_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }

        private void Button_balance_Click(object sender, RoutedEventArgs e)
        {
            BalanceWindow balanceWindow = new BalanceWindow();
            balanceWindow.Show();
            this.Close();
        }
    }
}
