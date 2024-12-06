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

namespace WpfApp1.Addition
{
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private Product _currentProduct = new Product();
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            using (WarehouseContext context = new WarehouseContext())
            {
                _currentProduct.Name = txtname.Text;
                _currentProduct.Description = txtdescription.Text;
                _currentProduct.Unit = txtunit.Text;
                _currentProduct.IdSupplier = Convert.ToInt32(txtsupplier.Text);
                if (_currentProduct.IdProduct == 0)
                {
                    context.Products.Add(_currentProduct);
                    context.SaveChanges();
                    MessageBox.Show("Новый товар успешно добавлен");
                }
                else
                {
                    context.Products.Update(_currentProduct);
                }
            }
            ProductWindow productwindow = new ProductWindow();
            productwindow.Show();
            this.Close();
        }

        private void BtnBacksProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productwindow = new ProductWindow();
            productwindow.Show();
            this.Close();
        }
    }
}
