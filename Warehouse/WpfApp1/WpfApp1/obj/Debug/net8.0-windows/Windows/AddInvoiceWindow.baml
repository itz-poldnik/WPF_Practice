   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	   &     WpfApp1.Windows.AddInvoiceWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	     � Title$  AddInvoiceWindow��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��Дата��6   $��1��5      $��0��5      �� 5   
   -   5        $��txtdate��5      $��1��5      $��1��5      ��5      �� *Date+5      �� 5   
   $��
Товар��6   $��2��5      $��0��5      �� 5    
   -   5        $��
txtproduct��5       $��2��5"      $��1��5#      ��5!      �� *Product.Name+5#      �� 5$   
   $��Количество��6   $��3��5%      $��0��5&      �� 5'   
   -   5        $��txtquantity��5'      $��3��5)      $��1��5*      ��5(      �� *
Quantity+5*      �� 5+   
   $��Магазин��6   $��4��5,      $��0��5-      �� 5.   
   -   5        $��txtshop��5.      $��4��50      $��1��51      ��5/      �� *	Shop.Name+51      �� 52   
   -   5        $��BtnSaveInvoice��57      $��Сохранить��52      $��2��53      $��5��54      $	��150��55      $��30��56      $��292,16,358,26q�58   .   �� 59   
   -   5        $��BtnBacksInvoice��5=      $��
Назад��59      $��5��5:      $	��150��5;      $��30��5<      $��1��5?      $��154,16,176,26q�6!   5@      5A      