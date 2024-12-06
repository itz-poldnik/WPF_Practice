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
    /// Логика взаимодействия для AddSupplierWindow.xaml
    /// </summary>
    public partial class AddSupplierWindow : Window
    {
        private Supplier _currentSupplier = new Supplier();
        public AddSupplierWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveSupplier_Click(object sender, RoutedEventArgs e)
        {
            using (WarehouseContext context = new WarehouseContext())
            {
                _currentSupplier.Name = txtname.Text;
                _currentSupplier.Phone = txtphone.Text;
                _currentSupplier.Address = txtaddress.Text;
                if (_currentSupplier.IdSupplier == 0)
                {
                    context.Suppliers.Add(_currentSupplier);
                    context.SaveChanges();
                    MessageBox.Show("Новый поставщик успешно добавлен");
                }
                else
                {
                    context.Suppliers.Update(_currentSupplier);
                }
            }
            SupplierWindow supplierwindow = new SupplierWindow();
            supplierwindow.Show();
            this.Close();
        }

        private void BtnBacksSupplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierWindow supplierwindow = new SupplierWindow();
            supplierwindow.Show();
            this.Close();
        }
    }
}
