   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	   '    !WpfApp1.Windows.AddSupplierWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	     � Title$  AddSupplierWindow��5   	   $	��450��6#   $	��800��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��Название��6   $��1��5      $��0��5      �� 5   
   -   5        $��txtname��5      $��1��5      $��1��5      ��5      �� *Name+5      �� 5   
   $��Телефон��6   $��2��5      $��0��5      �� 5   
   -   5        $��txtphone��5      $��2��5!      $��1��5"      ��5       �� *Phone+5"      �� 5#   
   $��
Адрес��6   $��3��5$      $��0��5%      �� 5&   
   -   5        $��
txtaddress��5&      $��3��5(      $��1��5)      ��5'      �� *	Address+5)      �� 5*   
   -   5        $��BtnSaveSupplier��5/      $��Сохранить��5*      $��2��5+      $��4��5,      $	��150��5-      $��30��5.      $��290,14,360,43q�50   /   �� 51   
   -   5        $��BtnBacksSupplier��55      $��
Назад��51      $��4��52      $	��150��53      $��30��54      $��1��57      $��155,14,175,43q�6!   58      59      