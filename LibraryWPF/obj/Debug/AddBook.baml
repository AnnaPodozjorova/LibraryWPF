   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.AddBook   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        ���	#FF734F83   MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	     � Title$  Add Book��5   	   $��574.429��6   $��603.429��6+    � 
ResizeMode$ NoResize=�6T    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      � .+�5   
   �� 
�������$��1q�6%   $
��Left=�69   $	��483��6T   $��	10,10,0,0q�6a   $	��Top=�6t   $	��575��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6#      Color$ White��5         Opacity$ 5Q�5      	   
BlurRadius$	 10Q�5      5      �� 5   
   
�������$
��Left=�6!   $	��524��6<   $��	10,10,0,0q�6I   
�������$	��Top=�6k   $	��575��6�   �� 5!   
   -   5        
 ��Name$
 titlebox��5!      $
��Left=�6$   $��34��6?   $��249,108,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��202��6�   �� 5"   
   -   5        $
 descbox��5"      $
��Left=�6#   $��34��6>   $��248,187,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��202��6�   �� 5#   
   -   5        $
 genrebox��5#      $
��Left=�6$   $��34��6?   $��248,265,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��202��6�   �� 5$   
   -   5        $
 shelfbox��5$      $
��Left=�6$   $��34��6?   $��248,226,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��202��6�   �� 5%   
   -   5        $
 Pricebox��5%      $
��Left=�6$   $��34��6?   $��248,343,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��202��6�   �� 5&   
   -   5        $
 quantitybox��5&      $
��Left=�6'   $��34��6B   $��248,304,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��202��6�   �� 5'   
   $��Title��6   $
��Left=�6    $��191,118,0,0q�6;   $	��Top=�6P   $��34��6h   $
��Bold"�6t   �� 5(   
   $��Description��6   $
��Left=�6&   $��145,191,0,0q�6A   $	��Top=�6V   $��34��6n   $
��Bold"�6z   �� 5)   
   $��Shelf��6   $
��Left=�6    $��186,230,0,0q�6;   $	��Top=�6P   $��34��6h    J� RenderTransformOrigin$ 1.071,0.826&�6t   $
��Bold"�6�   �� 5*   
   $��Genre��6   $
��Left=�6    $��180,264,0,0q�6;   $	��Top=�6P   $��34��6h   $
��Bold"�6t   �� 5+   
   $��Quantity��6   $
��Left=�6#   $��163,303,0,0q�6>   $	��Top=�6S   $��34��6k   $
��Bold"�6w   �� 5,   
   $��Price��6   $
��Left=�6    $��187,342,0,0q�6;   $	��Top=�6P   $��34��6h   $
��Bold"�6t   �� 5-   
   -   5        $
 NoteBox��5-      $
��Left=�6#   $��34��6>   $��248,382,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��202��6�   �� 5.   
   $
��Note��6   $
��Left=�6   $��187,382,0,0q�6:   $	��Top=�6O   $��34��6g   $
��Bold"�6s   �� 5/   
   $
��Book��6   $
��Left=�6   $��
266,61,0,0q�6:   $	��Top=�6N   $
��Bold"�6f   $��16(�6x   �� 50   
   -	   5         ��Name$ AddBtn��50      $��OK��6!   $
��Left=�6.   $��205,461,0,0q�6I   $	��Top=�6^   $��75��6v   $ 0.455,-0.656&�6�   6�   �� 51   
   -
   5        $ 	CancelBtn��51      $��Cancel��6$   $
��Left=�65   $��305,461,0,0q�6P   $	��Top=�6e   $��75��6}   $ 0.455,-0.656&�6�   6�   �� 52   
   $��Author��6   $
��Left=�6!   $��174,152,0,0q�6<   $	��Top=�6Q   $��34��6i   $
��Bold"�6u   �� 53   
   -   5        $
 	AuthorBox��53      $
��Left=�6%   $��34��6@   $��249,147,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��202��6�   55      56      