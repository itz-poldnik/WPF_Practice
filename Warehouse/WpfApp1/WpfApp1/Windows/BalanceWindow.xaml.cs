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

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для BalanceWindow.xaml
    /// </summary>
    public partial class BalanceWindow : Window
    {
        WarehouseContext whContext = new WarehouseContext();
        public BalanceWindow()
        {
            InitializeComponent();
            dtgBalance.ItemsSource = whContext.Balances.Include(x => x.IdProductNavigation).ToList();
             
            
        }

        private void rbUpBalance_Click(object sender, RoutedEventArgs e)
        {
            dtgBalance.ItemsSource = whContext.Balances.OrderBy(x=>x.Quantity).Include(x => x.IdProductNavigation).ToList();
        }

        private void rbDownBalance_Click(object sender, RoutedEventArgs e)
        {
            dtgBalance.ItemsSource = whContext.Balances.OrderByDescending(x => x.Quantity).Include(x => x.IdProductNavigation).ToList();
        }

        private void txtSearchBalance_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchBalance.Text;
            dtgBalance.ItemsSource = whContext.Balances.Where(x => x.IdProductNavigation.Name.Contains(searchText)).Include(x => x.IdProductNavigation).ToList();
        }

        
        private void btnAddBalance_Click(object sender, RoutedEventArgs e)
        {
            AddBalanceWindow addbalancewindow = new AddBalanceWindow();
            addbalancewindow.Show();
            this.Close();
        }

        private void BtnDeleteBalance_Click(object sender, RoutedEventArgs e)
        {
            var balanceForRemoving = dtgBalance.SelectedItems.Cast<Balance>().ToList();

            try
            {
                if (balanceForRemoving.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {balanceForRemoving.Count()} остатки продукции?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        whContext.Balances.RemoveRange(balanceForRemoving);
                    whContext.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgBalance.ItemsSource = whContext.Balances.Include(x => x.IdProductNavigation).ToList();
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

        private void BtnBackBalance_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
