   M S B A M L   `   `   `  ����A  =wpf_20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Harjoituts_20__WPF_Harjoituts_20__WPF_  5   	   $    Harjoituts_20__WPF_.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Harjoituts_20__WPF_     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)   .��5	      � $��Center=�6   $��Center=�6&   $	��564��6C   $	��880��6P   .+�5   
   � $��	728,0,0,0q�6   $
��Left=�6"   $	��152��6=    � RowDefinitions 5      �� 5      $
��277* �6    �� 5      $
��287* �6    .+�5      �� -   5         ��Name$ btnAddOpiskelija��5      $��Lisää Opiskelija��6/   $
��Left=�6J   $��Bottom=�6e   $	��108��6�   $��0,0,0,91q�6�   $��27��6�   �� 5      -   5         ��Name$ etunimiInput��5      $
��Left=�6,   $�� ��6G    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��0,36,0,0q�6�   �� 5      -   5        $ sukunimiInput��5      $
��Left=�6-   $�� ��6H   $
 Wrap=�6P   $	��Top=�6d   $	��120��6|   $��	-1,80,0,0q�6�   �� 5      -   5        $ opiskelijaIDInput��5      $
��Left=�61   $�� ��6L   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��
-1,128,0,0q�6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $	��109��6_   $��0,15,0,0q�6k   �� 6~    � Language$ en-fi�6�   $�Etunimi��6�   6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $	��109��6_   $��Sukunimi��6k   $��0,59,0,0q�6{   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $	��110��6_   $��
-1,108,0,0q�6k   �� 6�   $ en-fi�6�   $�OpiskelijaID��6�   6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $	��138��6_   $��	0,207,0,0q�6k   �� 6   $ en-fi�6�   $ �Poista Valitut Opiskelijat��6�   6�   �� 5      -   5        $ btnDeleteSelected��5      $��Poista Opiskelijat��60   $��
0,228,43,0q�6M   $	��Top=�6a   $��26��6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $	��138��6_   $��
-1,276,0,0q�6k   $��2��6   �� 6�   $�	Kokoelman��6�   �� 6�   $ en-fi�6�   $�	 Hallinta��6�   6�   �� 5      -   5        $ btnSaveToFile��5      $��Tallenna Tiedostoon��6,   $��
-1,32,44,0q�6J   $	��Top=�6^   $��1��6�   $��42��6�   �� 5      -   5        $ btnLoadFromFile��5      $��Hae Tiedostosta��6.   $��
-1,88,44,0q�6H   $	��Top=�6\   $��1��6�   $��42��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ OpiskelijatGrid��5      $	��450��6,   $
��Left=�6P   $	��Top=�6k      AutoGenerateColumns$ False��6�      CanUserReorderColumns$ False��6�   	   CanUserDeleteRows$	 False��6�   $��	10,99,0,0q�6�   ��68   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Etunimi��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 66      
IsReadOnly$
 True��6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	Etunimi+6^     5!      $ Sukunimi��6%   $	 150 67   $
 True��6`    6C   �� *
Sukunimi+6`     5"      $ Opiskelija ID��6%   $	 100 6<   $
 True��6i    6H   �� *OpiskelijaID+6i   4  .System.Windows.Controls.DataGridCheckBoxColumn  5#      $ Poista��6)   $	 50* 6X    69   �� *
IsSelected+6X   5%      �� 5'   
   -	   5         ��Name$ activityMessage��5'      $
��Left=�6-   $��10,8,0,0q�6H   $�� ��6Z   $
��Wrap=�6b   $	��Top=�6v   $	��656��6�   $��79��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5(      V� 5)      .~�5*      �� �� 5+       �� AngleX$ 1.548Q�6$   �� 5,      T� 5-       T� X$ 0.473Q�6)   5.      50      51      52      