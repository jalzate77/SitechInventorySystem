   M S B A M L   `   `   `  ����P  LSitechInventorySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:SitechInventorySystem.Modules.Maintenance)SitechInventorySystem.Modules.Maintenance  5      >    8SitechInventorySystem.Modules.Maintenance.SupplierModule   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:SitechInventorySystem.Modules.Maintenance     5      -   5        $��317.266��5      $��502.878��60   
�������.��5	      �   � RowDefinitions  5
   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $
��Wrap=�6B   $��Suppliers Module��6V   $��Center=�6n   $��5,0,0,0q�6�   $��20(�6�   $��Medium"�6�   � 5   
   $��0q�6   $��1��6    � ColumnDefinitions 5      �� 5      $	��40* �6#   �� 5      $	��60* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ gridRecords��5      $��10q�6,      HeadersVisibility$
 None=�6N   ���	#FFBABABA��68   Z�    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      CellTemplate 5      �� 5      .R�5   "   �� $ textRecordName��6,   ��6D   �� *Name+5      5        5       5      �� 5      .R�5    "   ��  ��Name$ 	btnDelete��6)   -   5        $	��✘��5    <   6H   5!      5#      5%      �� 5&      ���	#FFBCBCBC$��1q�6-   $��1��6A   $��10q�6Q   ._�5'      � $��0q�6     5(      �� 5)      $��25 �6(   �� 5*      $��25 �6(   �� 5+      $��25 �6(   �� 5,      $��25 �6(   �� 5-      $��* �6(   �� 5.      $��30 �6(   �� 5/      $��25 �6(   .+�51      �� -   5        $ 
textBlock1��51       $
��Left=�64   $��10,0,0,0q�6O   $��1��6a   $
��Wrap=�6n   $��Name:��6�   $��Center=�6�   �� 52      -   5        	 ��Name$	 textBox��52      $��23��6/   $��91,0,10,0.6q�6;   
 �� TextWrapping$

 Wrap=�6P   $��Bottom=�6d   $��1��6   $��Center=�6�   �� 53      $��30��6!   $��0q�6-   $��5��68    �� Orientation$ 
Horizontal=�6E   $��Center=�6^   .+�54      �� -   5        $ button_Copy��54   !   $
��Save��66   $	��2,5q�6E   $	��100��6R   ��6^   Z� �� 55      -   5        $ button��55   !   $��
New Record��61   $	��2,5q�6F   $	��100��6S   ��6_   Z� 56      �� 57      -	   5        $ textBlock1_Copy��57       $
��Left=�69   $��10,0,0,0q�6T   $��2��6f   $
��Wrap=�6s   $��Record State:��6�   $��Center=�6�   �� 58      -
   5         ��Name$ comboBox��58      $��	91,0,10,0q�61   $��2��6D   $��Center=�6Q   $��24��6l   ���	#FFB6B6B6��6x   Z� .@�59      �� $��Active��6'   �� 5:      $��Inactive��6'   5;      5<      5=      5>      5?      5@      