   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.Registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        ���	#FF793183   MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	     � Title$  Registration��5   	   $	��507��6   $	��404��6+    � 
ResizeMode$ NoResize=�6P    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      � $��0,0,0,-4q�6    � RowDefinitions 5   
   �� 5      .+�5   
   �� 
�������$��10q�6%   $
��Left=�6:   $	��409��6U   $��	29,27,0,0q�6b   $	��Top=�6u   $	��340��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6#      Color$ White��5      	   Opacity$	 5Q�5      
   
BlurRadius$
 10Q�5      5       �� 5"   
   
�������$
��Left=�6!   $	��409��6<   $��
29,27,0,45q�6I   $��Center=�6]   $	��340��6x   �� 5#   
   $��	Firstname��6   $
��Left=�6$   $	��Top=�6?    J� RenderTransformOrigin$ -0.214,-1.242&�6W   $��
96,125,0,0q�6}   �� 5$   
   $��Lastname��6   $
��Left=�6#   $	��Top=�6>   $ -0.214,-1.242&�6V   $��
97,162,0,0q�6|   �� 5%   
   $��Phone number��6   $
��Left=�6'   $	��Top=�6B   $ -0.214,-1.242&�6Z   $��
64,319,0,0q�6�   �� 5&   
   $��Address��6   $
��Left=�6"   $	��Top=�6=   $ -0.214,-1.242&�6U   $��107,280,0,0q�6{   �� 5'   
   $��E-mail��6   $
��Left=�6!   $	��Top=�6<   $ -0.214,-1.242&�6T   $��118,201,0,0q�6z   �� 5(   
   -   5         ��Name$ fnamebox��5(      $
��Left=�6$   $��34��6?   $��188,120,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��138��6�   �� 5)   
   -   5        $ lnamebox��5)      $
��Left=�6$   $��32��6?   $��188,159,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��138��6�   �� 5*   
   -   5        $ emailbox��5*      $
��Left=�6$   $��34��6?   $��188,196,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��138��6�   �� 5+   
   -   5        $ 
addressbox��5+      $
��Left=�6&   $��35��6A   $��188,274,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��138��6�   �� 5,   
   -   5        $ telephonebox��5,      $
��Left=�6(   $��34��6C   $��188,314,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��138��6�   �� 5-   
   $��Password��6   $
��Left=�6#   $	��Top=�6>   $ -0.214,-1.242&�6V   $��
98,240,0,0q�6|   �� 5.   
   -   5         ��Name$ 	submitbtn��5.      $��Submit��6$   $
��Left=�65   $��118,376,0,0q�6P   $	��Top=�6e   $��81��6}   6�   G� 5/   
   -   5         G�Name$ passbox��5/      $
��Left=�6'   $��188,235,0,0q�6B   $	��Top=�6W   $	��138��6o   $��34��6{   �� 50   
   $��Registration��6   $��18(�6'   $��Center=�65   $��96,78,184,0q�6R   $	��Top=�6g   $ 0.523,0.559&�6   $	��113��6�   �� 51   
   $��110,0,0,300q�6    + 'MaterialDesignFloatingActionLightButton#��[ 6&   
�������.��52      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ AccountCircle=�6&   $��50��6;   $��50��6G   53      �� 54   
   -	   5        $ closebtn��54      $��Close��6#   $
��Left=�63   $��211,376,0,0q�6N   $	��Top=�6c   $��81��6{   6�   56      57      