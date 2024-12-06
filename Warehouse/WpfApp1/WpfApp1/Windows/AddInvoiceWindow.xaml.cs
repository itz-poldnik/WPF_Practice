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
    /// Логика взаимодействия для AddInvoiceWindow.xaml
    /// </summary>
    public partial class AddInvoiceWindow : Window
    {
        private Invoice _currentInvoice = new Invoice();
        public AddInvoiceWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveInvoice_Click(object sender, RoutedEventArgs e)
        {
            using (WarehouseContext context = new WarehouseContext())
            {
                _currentInvoice.Date = DateOnly.Parse(txtdate.Text);
                _currentInvoice.IdProduct = Convert.ToInt32(txtproduct.Text);
                _currentInvoice.Quantity = Convert.ToInt32(txtquantity.Text);
                _currentInvoice.IdShop = Convert.ToInt32(txtshop.Text);
                if (_currentInvoice.IdProduct == 0)
                {
                    context.Invoices.Add(_currentInvoice);
                    context.SaveChanges();
                    MessageBox.Show("Новая накладная успешно добавлена");
                }
                else
                {
                    context.Invoices.Update(_currentInvoice);
                }
            }
            InvoiceWindow invoicewindow = new InvoiceWindow();
            invoicewindow.Show();
            this.Close();
        }

        private void BtnBacksInvoice_Click(object sender, RoutedEventArgs e)
        {
            InvoiceWindow invoicewindow = new InvoiceWindow();
            invoicewindow.Show();
            this.Close();
        }
    }
}
