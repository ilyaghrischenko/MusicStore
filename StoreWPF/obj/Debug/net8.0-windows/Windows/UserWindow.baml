   M S B A M L   `   `   `  ����C  ?StoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StoreWPF.WindowsStoreWPF.Windows  5   	   !    StoreWPF.Windows.UserWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StoreWPF.Windows     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.1* �6   �� 5      $��3* �6   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      �� 5      $	��16* �6    �� 5      .+�5      �� $��1��6   .��5      �� -   5         ��Name$ 
AlbumsList��5      5      5      5      � 5   
   $��3��6    5       �� 5!      $
��2.5* �6    �� 5"      �� 5#      $
��2.5* �6    �� 5$      �� 5%      $
��2.5* �6    .+�5(      �� -   5         ��Name$ 	BuyButton��5*      $��1��5(      $	��Buy��5)      ${�False��5,      �� 5-      -   5        $ SearchButton��5/      $��3��5-      $��Search��5.      50      51      52      53      