   M S B A M L   `   `   `  ����E  AViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ViewModels.ViewModelViewModels.ViewModel  5      1clr-namespace:ViewModels.ViewViewModels.View  5          ViewModels.View.Customers   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8	ViewModel"clr-namespace:ViewModels.ViewModel     5      /localclr-namespace:ViewModels.View     5      3fa$http://schemas.fontawesome.io/icons/     5	      .��5      � .+�5   
   �� -   5          ��Name$  searchTextBox��5   )   
 � Tag$ Search Customers��6   $
��Left=�6�   $��40��6�   $��10,9,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��340��6�   $��5,6,0,0q�6
  $��16(�6  ��6@   �� *SelectedCustomer.Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6  �� 5   
   $��430,0,436,263q�6?   ��6   ��  �� Path$ SelectedCustomer.Name�6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ customerListBox��5         SelectionMode$ Single=�6{      
IsReadOnly . $��10,57,10,10q�6�   	 �� AlternationCount$	 2��6�   $��1q�6�   
 J� SnapsToDevicePixels
 .    AutoGenerateColumns .   �� SelectedItem 6,   �� *SelectedCustomer+$ PropertyChanged=���6�   �� *	Customers+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6<     5      $
 Name��6?    6%   �� *Name+6?     5      $ Address��6C    6%   �� *
Address1+6C     5      $ 	Address 2��6C    6%   �� *
Address2+6C     5      $
 Town��6?    6%   �� *Town+6?     5      $ County��6A    6%   �� *County+6A     5      $ Postcode��6C    6%   �� *
Postcode+6C     5      $ Phone��6@    6%   �� *Phone+6@     5      $ Email��6?    6%   �� *Email+6?   5      5      5      