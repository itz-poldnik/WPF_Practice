   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp1.AdditionWpfApp1.Addition  5   	   '    !WpfApp1.Addition.AddProductWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfApp1.Addition     5   	     � Title$  AddProductWindow��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��Название��6   $��1��5      $��0��5      �� 5   
   -   5        $��txtname��5      $��1��5      $��1��5      ��5      �� *Name+5      �� 5   
   $��Описание��6   $��2��5      $��0��5      �� 5    
   -   5        $��txtdescription��5       $��2��5"      $��1��5#      ��5!      �� *Description+5#      �� 5$   
   $��Ед. измерения��6   $��3��5%      $��0��5&      �� 5'   
   -   5        $��txtunit��5'      $��3��5)      $��1��5*      ��5(      �� *Unit+5*      �� 5+   
   $��Поставщик��6   $��4��5,      $��0��5-      �� 5.   
   -   5        $��txtsupplier��5.      $��4��50      $��1��51      ��5/      �� *Supplier.Name+51      �� 52   
   -   5        $��BtnSaveProduct��57      $��Сохранить��52      $��2��53      $��5��54      $	��150��55      $��30��56      $��270,16,380,26q�58   .   �� 59   
   -   5        $��BtnBacksProduct��5=      $��
Назад��59      $��5��5:      $	��150��5;      $��30��5<      $��1��5?      $��150,16,180,26q�6!   5@      5A      