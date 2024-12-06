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
using System.Xml.Linq;
using WpfApp1.Classes;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        private Order _currentOrder = new Order();
        public AddOrderWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            using (WarehouseContext context = new WarehouseContext())
            {
                _currentOrder.Date = DateOnly.Parse(txtdate.Text);
                _currentOrder.IdSupplier = Convert.ToInt32(txtsupplier.Text);
                _currentOrder.IdProduct = Convert.ToInt32(txtproduct.Text);
                _currentOrder.Quantity = Convert.ToInt32(txtquantity.Text);
                _currentOrder.Price = Convert.ToDecimal(txtprice.Text);
                if (_currentOrder.IdProduct == 0)
                {
                    context.Orders.Add(_currentOrder);
                    context.SaveChanges();
                    MessageBox.Show("Новый заказ успешно добавлен");
                }
                else
                {
                    context.Orders.Update(_currentOrder);
                }
            }
            OrderWindow orderwindow = new OrderWindow(); 
            orderwindow.Show();
            this.Close();
        }

        private void BtnBacksOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderwindow = new OrderWindow();
            orderwindow.Show();
            this.Close();
        }
    }
}
