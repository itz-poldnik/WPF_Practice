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
    /// Логика взаимодействия для SupplierWindow.xaml
    /// </summary>
    public partial class SupplierWindow : Window
    {
        WarehouseContext whContext = new WarehouseContext();
        public SupplierWindow()
        {
            InitializeComponent();
            dtgSupplier.ItemsSource = whContext.Suppliers.ToList();

            cmbViewSupplier.ItemsSource = whContext.Suppliers.ToList();
            cmbViewSupplier.SelectedValuePath = "IdSupplier";
            cmbViewSupplier.DisplayMemberPath = "Address";
        }

        //private void BtnEditSupplier_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void rbUpSupplier_Click(object sender, RoutedEventArgs e)
        {
            dtgSupplier.ItemsSource = whContext.Suppliers.OrderBy(x => x.Name).ToList();
        }

        private void rbDownSupplier_Click(object sender, RoutedEventArgs e)
        {
            dtgSupplier.ItemsSource = whContext.Suppliers.OrderByDescending(x => x.Name).ToList();
        }

        private void txtSearchSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchSupplier.Text;
            dtgSupplier.ItemsSource = whContext.Suppliers.Where(x => x.Name.Contains(searchText)).ToList();
        }

        private void cmbViewSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Supplier = int.Parse(cmbViewSupplier.SelectedValue.ToString());
            dtgSupplier.ItemsSource = whContext.Suppliers.Where(x => x.IdSupplier == Supplier).ToList();
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            AddSupplierWindow addsupplierwindow = new AddSupplierWindow();
            addsupplierwindow.Show();
            this.Close(); 
        }

        private void BtnDeleteSupplier_Click(object sender, RoutedEventArgs e)
        {
            var supplierForRemoving = dtgSupplier.SelectedItems.Cast<Supplier>().ToList();

            try
            {
                if (supplierForRemoving.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {supplierForRemoving.Count()} поставщика?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        whContext.Suppliers.RemoveRange(supplierForRemoving);
                    whContext.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgSupplier.ItemsSource = whContext.Suppliers.ToList();
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

        private void BtnBackSupplier_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
