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
using WpfApp1.Classes;
using WpfApp1.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для InvoiceWindow.xaml
    /// </summary>
    public partial class InvoiceWindow : Window
    {
        WarehouseContext whContext = new WarehouseContext();
        public InvoiceWindow()
        {
            InitializeComponent();
            dtgInvoice.ItemsSource = whContext.Invoices.Include(x=>x.IdProductNavigation).ToList();
            dtgInvoice.ItemsSource = whContext.Invoices.Include(x => x.IdShopNavigation).ToList();

            cmbViewInvoice.ItemsSource = whContext.Invoices.ToList();
            cmbViewInvoice.SelectedValuePath = "IdInvoice";
            cmbViewInvoice.DisplayMemberPath = "IdShopNavigation.Name";
        }

        //private void BtnEditInvoice_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void rbUpInvoice_Click(object sender, RoutedEventArgs e)
        {
            dtgInvoice.ItemsSource = whContext.Invoices.OrderBy(x=>x.Date).ToList();
        }

        private void rbDownInvoice_Click(object sender, RoutedEventArgs e)
        {
            dtgInvoice.ItemsSource = whContext.Invoices.OrderByDescending(x=>x.Date).ToList();
        }

        private void txtSearchInvoice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchInvoice.Text;
            dtgInvoice.ItemsSource = whContext.Invoices.Where(x => x.IdProductNavigation.Name.Contains(searchText)).ToList();
        }

        private void cmbViewInvoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Invoice = int.Parse(cmbViewInvoice.SelectedValue.ToString());
            dtgInvoice.ItemsSource = whContext.Invoices.Where(x => x.IdShop == Invoice).ToList();
        }

        private void btnAddInvoice_Click(object sender, RoutedEventArgs e)
        {
            AddInvoiceWindow addinvoicewindow = new AddInvoiceWindow();
            addinvoicewindow.Show();
            this.Close();
        }

        private void BtnDeleteInvoice_Click(object sender, RoutedEventArgs e)
        {
            var invoiceForRemoving = dtgInvoice.SelectedItems.Cast<Invoice>().ToList();

            try
            {
                if (invoiceForRemoving.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {invoiceForRemoving.Count()} накладную?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        whContext.Invoices.RemoveRange(invoiceForRemoving);
                    whContext.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgInvoice.ItemsSource = whContext.Invoices.ToList();
                }
                else
                    MessageBox.Show("Данные не указаны", "Внимание", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные невозможно удалить", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnBackInvoice_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
