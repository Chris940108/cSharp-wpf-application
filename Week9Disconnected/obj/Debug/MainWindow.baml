   M S B A M L   `   `   `  ����L  HWeek9Disconnected, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Week9DisconnectedWeek9Disconnected  5   	   "    Week9Disconnected.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Week9Disconnected     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��grdProducts��5
   *   $��28,34,372,34q�6   6*   �� 5   
   -   5         ��Name$ btnLoadAllProducts��5      $��Load All Products��6-   $	��134��6I   $
��Left=�6U   $��45��6p   $	��Top=�6|   $��
454,48,0,0q�6�   �� 5   
   -   5        $ btnClearData��5      $��
Clear Data��6'   $	��136��6<   $
��Left=�6H   $��45��6c   $	��Top=�6o   $��
628,48,0,0q�6�   �� 5   
   -   5         ��Name$	 lb1��5      $	��ID:��6   $
��Left=�6+   $	��Top=�6F    J� RenderTransformOrigin$ 0.533,-0.589&�6^   $��470,120,0,0q�6�   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��547,124,0,0q�6<   $	��Top=�6Q   $��50��6i   �� 5   
   -   5        $ btnFind��5      $
��Find��6"   $	��120��61   $
��Left=�6=   $��28��6X   $	��Top=�6d   $��636,119,0,0q�6�   �� 5   
   -   5        $	 lb2��5      $��Name: ��6   $
��Left=�6.   $��470,151,0,0q�6I   $	��Top=�6^   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��547,155,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��210��6   �� 5   
   -	   5        $	 lb3��5      $��Price: ��6   $
��Left=�6/   $��470,178,0,0q�6J   $	��Top=�6_   �� 5   
   -
   5        $ txtPrice��5      $
��Left=�6$   $��547,182,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��210��6�   �� 5   
   -   5        $	 lb4��5      $��
Quantity: ��6   $
��Left=�62   $��470,217,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ txtQuantity��5      $
��Left=�6'   $��547,221,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��210��6�   �� 5   
   -   5        $ 	btnInsert��5      $��Insert��6$   $��78��65   $
��Left=�6@   $��47��6[   $	��Top=�6g   $��453,265,0,0q�6�   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $��78��65   $
��Left=�6@   $��47��6[   $	��Top=�6g   $��560,265,0,0q�6�   �� 5    
   -   5        $ 	btnDelete��5       $��Delete��6$   $��78��65   $
��Left=�6@   $��47��6[   $	��Top=�6g   $��665,265,0,0q�6�   �� 5!   
   -   5        $ btnShowWindow2��5!      $��Show Window 2��6)   $	��195��6A   $
��Left=�6M   $��47��6h   $	��Top=�6t   $��501,332,0,0q�6�   5#      5$      