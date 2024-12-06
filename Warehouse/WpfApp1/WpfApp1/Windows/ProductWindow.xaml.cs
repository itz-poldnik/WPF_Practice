using Microsoft.EntityFrameworkCore;
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
using WpfApp1.Addition;
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        WarehouseContext whContext = new WarehouseContext();
        public ProductWindow()
        {
            InitializeComponent();
            dtgProduct.ItemsSource = whContext.Products.Include(x=>x.IdSupplierNavigation).ToList();

            cmbViewProduct.ItemsSource = whContext.Products.ToList();
            cmbViewProduct.SelectedValuePath = "IdProduct";
            cmbViewProduct.DisplayMemberPath = "IdSupplierNavigation.Name";
        }

        private void rbUpProduct_Click(object sender, RoutedEventArgs e)
        {
            dtgProduct.ItemsSource = whContext.Products.OrderBy(x=>x.Name).ToList();
        }

        private void rbDownProduct_Click(object sender, RoutedEventArgs e)
        {
            dtgProduct.ItemsSource = whContext.Products.OrderByDescending(x => x.Name).ToList();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addproductwindow = new AddProductWindow();
            addproductwindow.Show();
            this.Close();
        }

        private void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            var productForRemoving = dtgProduct.SelectedItems.Cast<Product>().ToList();

            try
            {
                if (productForRemoving.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {productForRemoving.Count()} товар?", "Внимание", 
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        whContext.Products.RemoveRange(productForRemoving);
                    whContext.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgProduct.ItemsSource = whContext.Products.ToList();
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

        private void BtnBackProduct_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }

        private void txtSearchProduct_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchProduct.Text;
            dtgProduct.ItemsSource = whContext.Products.Where(x => x.Name.Contains(searchText)).ToList();
        }

        private void cmbViewProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Product = int.Parse(cmbViewProduct.SelectedValue.ToString());
            dtgProduct.ItemsSource = whContext.Products.Where(x=>x.IdSupplier == Product).ToList();
        }  

        //private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        //{
            
        //}
    }
}
