   M S B A M L   `   `   `  ����E  AViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ViewModels
ViewModels  5   	   ;"clr-namespace:ViewModels.ViewModelViewModels.ViewModel  5   	   1clr-namespace:ViewModels.ViewViewModels.View  5   	       ViewModels.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ViewModels     5   	   1VM"clr-namespace:ViewModels.ViewModel     5   	   .Viewclr-namespace:ViewModels.View     5   	     � Title$  
MainWindow��5
   	   $��592.372��6   $��863.49��6-    � DataContext 5      !  ViewModels.ViewModel.MainVM  5   
   6    � 	Resources 5       �� DataType&   ViewModels.ViewModel.CustomersVM   ViewModels.View.Customers&   ViewModels.ViewModel.SuppliersVM   ViewModels.View.Suppliers��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��62* �6   �� 5      $	��33* �6   .+�5   
   �� $��0,53,296,10q�6;   $��2��6P   ��6   �� *SelectedMain+6P   �� 5   
   $��5.136,53,10,22q�6>   $��1��6V   ��6   �� *SettingsControl+6V   �� 5    
   $��	Customers��6   $��0��6K   $
��Left=�6`   $��	10,10,0,0q�6{   $	��Top=�6�   $��75��6�   ��6%   �� *NavigationCommand+6�   �� 5!   
   $��	Suppliers��6   $��1��6K   $
��Left=�6`   $��	90,10,0,0q�6{   $	��Top=�6�   $��75��6�   ��6%   �� *NavigationCommand+6�   5"      5#      