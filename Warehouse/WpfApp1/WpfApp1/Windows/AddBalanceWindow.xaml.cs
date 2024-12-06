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
    /// Логика взаимодействия для AddBalanceWindow.xaml
    /// </summary>
    public partial class AddBalanceWindow : Window
    {
        private Balance _currentBalance = new Balance();
        public AddBalanceWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveBalance_Click(object sender, RoutedEventArgs e)
        {
            using (WarehouseContext context = new WarehouseContext())
            {
                _currentBalance.IdProduct = Convert.ToInt32(txtproduct.Text);
                _currentBalance.Quantity = Convert.ToInt32(txtquantity.Text);
                if (_currentBalance.IdBalance == 0)
                {
                    context.Balances.Add(_currentBalance);
                    context.SaveChanges();
                    MessageBox.Show("Новый товар успешно добавлен");
                }
                else
                {
                    context.Balances.Update(_currentBalance);
                }
            }
            BalanceWindow balancewindow = new BalanceWindow();
            balancewindow.Show();
            this.Close();
        }

        private void BtnBacksBalance_Click(object sender, RoutedEventArgs e)
        {
            BalanceWindow balancewindow = new BalanceWindow();
            balancewindow.Show();
            this.Close();
        }
    }
}
