   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	   !    LibraryWPF.UserControlPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        ���	#FF793183   MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	     � Title$  User Control Panel��5   	   $��665.571��6$   $��682.571��65    � 
ResizeMode$ NoResize=�6^    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      � $��0,0,2,0q�6   .+�5   
   �� 
�������$��1q�6%   $
��Left=�69   $	��513��6T   $��	10,10,0,0q�6a   $	��Top=�6t   $	��655��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6#      Color$ White��5         Opacity$ 5Q�5      	   
BlurRadius$	 10Q�5      5      �� 5    
   
�������$
��Left=�6!   $	��616��6<   $��	10,10,0,0q�6I   
�������$	��Top=�6k   $	��655��6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        
  Name$
 	UsersGrid��5"      $
��Left=�6&   $	��210��6A   $��
28,124,0,0q�6N   $	��Top=�6b   $	��617��6z      AutoGenerateColumns .  ��6�   ��    Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *UserId+  5%      $ 	Firstname��6%    68   �� *	Firstname+  5&      $ Lastname��6%    67   �� *
Lastname+  5'      $ Phone number��6%    6;   �� *	Telephone+  5(      $ Address��6%    66   �� *	Address+  5)      $ E-mail��6%    65   �� *E-mail+  5*      $
 Fine��6%    63   �� *ToPay+5,      �� 5-   
   $��Users��6   $
��Left=�6    $��	28,93,0,0q�6;   $	��Top=�6N   $
��Bold"�6f   �� 5.   
   -   5         ��Name$ EditBtn��5.      $
��Edit��6"   $
��Left=�61   $��570,339,0,0q�6L   $	��Top=�6a   $��75��6y    J� RenderTransformOrigin$ 0.455,-0.656&�6�   $��34��6�     5/   
   -   5        $
 RentingHistoryGrid��5/      $
��Left=�6/   $	��176��6J   $��
28,396,0,0q�6W   $	��Top=�6k   $	��617��6�    .  ��6�   ��  50        51      $ ID��6%    61   �� *BookId+  52      $ Title��6%    64   �� *Title+  53      $ Description��6%    6:   �� *Description+  54      $ Author��6%    65   �� *Author+  55      $ Shelf��6%    64   �� *Shelf+  56      $ Genre��6%    64   �� *Genre+  57      $ Quantity��6%    67   �� *
Quantity+  58      $ Price��6%    64   �� *Price+  59      $ Notes��6%    64   �� *Notes+5;      �� 5<   
   $��Rented Books��6   $
��Left=�6'   $��
28,362,0,0q�6B   $	��Top=�6V   �� 5=   
   -   5         ��Name$ 	SearchBox��5=      $
��Left=�6%   $��34��6@   $��	29,57,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��186��6�   �� 5>   
   -   5         ��Name$ CriteriumCombobox��5>      $
��Left=�6.   $��
237,57,0,0q�6I   $	��Top=�6]   $	��133��6u   $ 0.454,0.019&�6�   $��34��6�   
�������6�   �� 5?   
   -   5        $ FindBtn��5?      $
��Find��6"   $
��Left=�61   $��
390,57,0,0q�6L   $	��Top=�6`   $��75��6x   $ 0.455,-0.656&�6�   $��34��6�   �� 5@   
   $
��Find��6   $
��Left=�6   $��	29,31,0,0q�6:   $	��Top=�6M   $��34��6e   $
��Bold"�6q   �� 5A   
   $��Category��6   $
��Left=�6#   $��
237,31,0,0q�6>   $	��Top=�6R   $��34��6j   $
��Bold"�6v   �� 5B   
   -   5        $��Cancel��5B      $
��Left=�6"   $��570,577,0,0q�6=   $	��Top=�6R   $��75��6j   $��34��6u   6�   5D      5E      