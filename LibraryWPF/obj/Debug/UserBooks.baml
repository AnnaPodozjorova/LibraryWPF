   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.UserBooks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ���	#FF793183   MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	     � Title$  Books information��5   	   $��763.504��6#   $��1060.786��64    � 
ResizeMode$ NoResize=�6E    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      � $��0,0,-8,0q�6   .+�5   
   �� 
�������$��10q�6%   $
��Left=�6:   $	��699��6U   $��	10,10,0,0q�6b   $	��Top=�6u   $
��1028��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6#      Color$ White��5         Opacity$ 5Q�5      	   
BlurRadius$	 10Q�5      5       �� 5"   
   
�������$
��Left=�6!   $	��699��6<   $��	10,10,0,0q�6I   $	��Top=�6\   $
��1028��6t   �� 5$   
   -   5        
 ��Name$
 	SearchBox��5$      $
��Left=�6%   $��32��6@   $��	40,52,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��186��6�   �� 5%   
   -   5         ��Name$ CriteriumCombobox��5%      $
��Left=�6.   $��
249,50,0,0q�6I   $	��Top=�6]   $	��161��6u    J� RenderTransformOrigin$ 0.454,0.019&�6�   $��34��6�   
�������6�   �� 5&   
   $
��Find��6   $
��Left=�6   $��	40,25,0,0q�6:   $	��Top=�6M   $��27��6e   $ 
0.595,0.63&�6q   $
��Bold"�6�   5'      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ BooksDataGrid��5(      $
��Left=�6*   $	��286��6E   $��	40,95,0,0q�6R   $	��Top=�6e   $	��620��6}      AutoGenerateColumns .  ��6�   ��    Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *BookId+  5+      $ Title��6%    64   �� *Title+  5,      $ Description��6%    6:   �� *Description+  5-      $ Author��6%    65   �� *Author+  5.      $ Shelf��6%    64   �� *Shelf+  5/      $ Genre��6%    64   �� *Genre+  50      $ Quantity��6%    67   �� *
Quantity+  51      $ Price��6%    64   �� *Price+  52      $ Notes��6%    64   �� *Notes+54      �� 56   
   -   5         ��Name$ RentBtn��56      $
��Rent��6"   $
��Left=�61   $��570,386,0,0q�6L   $	��Top=�6a   $��90��6y   $ 0.455,-0.656&�6�   $��34��6�   �� 57   
   -   5        $ 
ProfileBtn��57      $��Profile��6%   $
��Left=�67   $��
793,20,0,0q�6R   $	��Top=�6f   $��90��6~   $ 	0.488,1.5&�6�   $��34��6�   �� 58   
   -   5        $ 	LogOutBtn��58      $��Log out��6$   $
��Left=�66   $��
902,20,0,0q�6Q   $	��Top=�6e   $��90��6}   $ 
0.32,0.656&�6�   $��34��6�     59   
   -   5        $ RentedBooksGrid��59      $
��Left=�6,   $	��197��6G   $��
40,445,0,0q�6T   $	��Top=�6h   $	��620��6�    .  ��6�   ��  5:        5;      $ ID��6%    61   �� *BookId+  5<      $ Title��6%    64   �� *Title+  5=      $ Description��6%    6:   �� *Description+  5>      $ Shelf��6%    64   �� *Shelf+  5?      $ Genre��6%    64   �� *Genre+  5@      $ Price��6%    64   �� *Price+  5A      $ Notes��6%    64   �� *Notes+5C      �� 5E   
   $��Rented Books��6   $
��Left=�6'   $��
40,416,0,0q�6B   $	��Top=�6V   $��14(�6n   $
��Bold"�6|   &   System.Windows.Controls.Calendar  5F   
   -   5          Name$ Calendar��5F      $
��Left=�6%   $��
702,90,0,0q�6@   $	��Top=�6T   $	��363��6l   $	��290��6y   �� 5G   
   -	   5         ��Name$ RentInfoTextBlock��5G      $
��Left=�6/   $��702,495,0,0q�6J   $
��Wrap=�6_   $	��Top=�6s   $��77��6�   $	��290��6�   ���	#FFCBBFD1$
��Bold"�6�   6�   �� 5H   
   $��	Rent info��6   $
��Left=�6$   $��702,456,0,0q�6?   $	��Top=�6T   $ -0.109,-0.231&�6l   $��14(�6�   $
��Bold"�6�   �� 5I   
   -
   5        $ FindBtn��5I      $
��Find��6"   $
��Left=�61   $��
433,50,0,0q�6L   $	��Top=�6`   $��90��6x   $ 0.455,-0.656&�6�   $��34��6�   �� 5J   
   -   5        $ 	ReturnBtn��5J      $��Return��6$   $
��Left=�65   $��570,647,0,0q�6P   $	��Top=�6e   $��90��6}   $ 0.455,-0.656&�6�   $��34��6�   �� 5K   
   $��Category��6   $
��Left=�6#   $��
249,25,0,0q�6>   $	��Top=�6R   $��27��6j   $
��Bold"�6v   5M      5N      