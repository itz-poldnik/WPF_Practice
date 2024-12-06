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
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        WarehouseContext whContext = new WarehouseContext();
        public OrderWindow()
        {
            InitializeComponent();
            dtgOrder.ItemsSource = whContext.Orders.Include(x=>x.IdSupplierNavigation).ToList();
            dtgOrder.ItemsSource = whContext.Orders.Include(x => x.IdProductNavigation).ToList();

            cmbViewOrder.ItemsSource = whContext.Orders.ToList();
            cmbViewOrder.SelectedValuePath = "IdOrder";
            cmbViewOrder.DisplayMemberPath = "IdSupplierNavigation.Name";
        }

        //private void BtnEditOrder_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void rbUpOrder_Click(object sender, RoutedEventArgs e)
        {
            dtgOrder.ItemsSource = whContext.Orders.OrderBy(x=>x.Date).ToList();
        }

        private void rbDownOrder_Click(object sender, RoutedEventArgs e)
        {
            dtgOrder.ItemsSource = whContext.Orders.OrderByDescending(x=>x.Date).ToList();
        }

        private void txtSearchOrder_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchOrder.Text;
            dtgOrder.ItemsSource = whContext.Orders.Where(x=>x.IdProductNavigation.Name.Contains(searchText)).ToList();
        }

        private void cmbViewOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Order = int.Parse(cmbViewOrder.SelectedValue.ToString());
            dtgOrder.ItemsSource = whContext.Orders.Where(x => x.IdSupplier == Order).ToList();
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addorderwindow = new AddOrderWindow();
            addorderwindow.Show();
            this.Close();
        }

        private void BtnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var orderForRemoving = dtgOrder.SelectedItems.Cast<Order>().ToList();

            try
            {
                if (orderForRemoving.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {orderForRemoving.Count()} заказ?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        whContext.Orders.RemoveRange(orderForRemoving);
                    whContext.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgOrder.ItemsSource = whContext.Orders.ToList();
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

        private void BtnBackOrder_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
