   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.AdminBooks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        ���	#FF793183   MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	     � Title$  Admin Books��5   	   $��541.66��6   $��775.242��6-    � 
ResizeMode$ NoResize=�6=    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      � .+�5   
   �� 
�������$
��Left=�6!   $	��478��6<   $��	10,10,0,0q�6I   
�������$	��Top=�6k   $	��747��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6#      Color$ White��5         Opacity$ 5Q�5      	   
BlurRadius$	 10Q�5      5      �� 5    
   -   5        
 ��Name$
 	SearchBox��5       $
��Left=�6%   $��34��6@   $��
40,103,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��186��6�   �� 5!   
   -   5         ��Name$ CriteriumCombobox��5!      $
��Left=�6.   $��248,103,0,0q�6I   $	��Top=�6^   $	��155��6v    J� RenderTransformOrigin$ 0.454,0.019&�6�   $��34��6�   
�������6�   �� 5"   
   $
��Find��6   $
��Left=�6   $��	40,76,0,0q�6:   $	��Top=�6M   $��27��6e   $
��Bold"�6q   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ BooksDataGrid��5#      $
��Left=�6*   $	��260��6E   $��
40,152,0,0q�6R   $	��Top=�6f   $	��699��6~      AutoGenerateColumns .  ��6�   ��    Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *BookId+  5&      $ Title��6%    64   �� *Title+  5'      $ Description��6%    6:   �� *Description+  5(      $ Author��6%    65   �� *Author+  5)      $ Shelf��6%    64   �� *Shelf+  5*      $ Genre��6%    64   �� *Genre+  5+      $ Quantity��6%    67   �� *
Quantity+  5,      $ Price��6%    64   �� *Price+  5-      $ Notes��6%    64   �� *Notes+5/      �� 50   
   -   5         ��Name$ AddBtn��50      $	��Add��6!   $
��Left=�6/   $��
40,427,0,0q�6J   $	��Top=�6^   $��90��6v   $ 0.455,-0.656&�6�   $��34��6�   �� 51   
   -   5        $ 
ProfileBtn��51      $��Profile��6%   $
��Left=�68   $��
541,19,0,0q�6S   $	��Top=�6g   $��90��6   $ 	0.488,1.5&�6�   $��34��6�   �� 52   
   -   5        $ 	LogOutBtn��52      $��Log out��6$   $
��Left=�66   $��
649,19,0,0q�6Q   $	��Top=�6e   $��90��6�   $��34��6�   �� 53   
   -   5        $ 	DeleteBtn��53      $��Delete��6$   $
��Left=�65   $��135,427,0,0q�6P   $	��Top=�6e   $��90��6}   $ 0.455,-0.656&�6�   $��34��6�   �� 54   
   -	   5        $ EditBtn��54      $
��Edit��6#   $
��Left=�62   $��230,427,0,0q�6M   $	��Top=�6b   $��90��6z   $ 0.455,-0.656&�6�   $��34��6�   �� 55   
   -
   5        $ UserControlPanelBtn��55      $��User Control Panel��6.   $
��Left=�6K   $��582,427,0,0q�6f   $	��Top=�6{   $	��157��6�   $ 0.455,-0.656&�6�   $��34��6�   �� 56   
   -   5        $ FindBtn��56      $
��Find��6"   $
��Left=�61   $��421,103,0,0q�6L   $	��Top=�6a   $��90��6y   $ 	0.488,1.5&�6�   $��34��6�   �� 57   
   $��Category��6   $
��Left=�6#   $��
250,76,0,0q�6>   $	��Top=�6R   $��27��6j   $
��Bold"�6v   �� 58   
   $!��Administrator control panel��6   $
��Left=�66   $��	34,24,0,0q�6Q   $	��Top=�6d   $
��Bold"�6|   59      5:      