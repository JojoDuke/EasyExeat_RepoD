   M S B A M L   `   `   `  ����F  BNew_EZexeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:New_EZexeat.PagesNew_EZexeat.Pages  5      "    New_EZexeat.Pages.StudentsDB   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:New_EZexeat.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension     Kind$ FadeIn=�   Duration$ 0:0:0.3X�.��5   
       6.     $ ExpandIn=�$ 0:0:0.4X�.��5      � .+�5      �� $	��900��6   $	��420��6%    �� CornerRadius$ 30��62   
�������$��0 80 0 0q�6W    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 10Q�6+      	Direction$	 288Q�6<      Opacity$ 0.295Q�6L      
BlurRadius$ 15Q�6\   ._�5      � .+�5      �� 
�������$��3q�69   
������ $	��850��6f   $	��390��6r   $ 30��6   ._�5      � .+�5   "   �� 
�������$��3q�6A   
������ $	��Top=�6n   $��Center=�6�   $ 	30 30 0 0��6�   $	��850��6�   $��50��6�   $��0,-4,0,0q�6�   �� 5   "   	 �� Orientation$	 
Horizontal=�6-   $��Center=�6F   $��0 10 0 0q�6c   $��DemiBold"�6u   $��18(�6�   .+�5   &   �� $��Student Name��60   $��0 0 30 0q�6D   �� 5   &   $��School Name��60   $��0 0 30 0q�6C   �� 5   &   $��
House Name��60   $��0 0 30 0q�6B   �� 5   &   $��Program��60   $��0 0 30 0q�6?   �� 5   &   $��Phone Number��60   $��0 0 40 0q�6D   �� 5   &   $��Address��60   $��0 0 30 0q�6?   5   #   �� 5!   "   $��5 50 0 0q�6-   .+�5"   &   �� $��
Duke Opoku��60   $��SemiBold"�6B   $��18(�6X   $��0 0 0 10q�6f   �� 5#   &   $��Samuel Jackson��60   $��SemiBold"�6F   $��18(�6\   $��0 0 0 10q�6j   �� 5$   &   $��Brian Griffin��60   $��SemiBold"�6E   $��18(�6[   $��0 0 0 10q�6i   5%   #   �� 5'   "   $��
180 50 0 0q�6-   .+�5(   &   �� $��OWASS��60   $��SemiBold"�6=   $��18(�6S   $��0 0 0 10q�6a   �� 5)   &   $��PC��60   $��SemiBold"�6:   $��18(�6P   $��0 0 0 10q�6^   �� 5*   &   $��PRESEC��60   $��SemiBold"�6>   $��18(�6T   $��0 0 0 10q�6b   5+   #   �� 5-   "   $��
310 50 0 0q�6-   .+�5.   &   �� $��	St.Peters��60   $��SemiBold"�6A   $��18(�6W   $��0 0 0 10q�6e   �� 5/   &   $��St.John��60   $��SemiBold"�6?   $��18(�6U   $��0 0 0 10q�6c   �� 50   &   $��St.James��60   $��SemiBold"�6@   $��18(�6V   $��0 0 0 10q�6d   51   #   �� 53   "   $��
450 50 0 0q�6-   .+�54   &   �� $��Science��60   $��SemiBold"�6?   $��18(�6U   $��0 0 0 10q�6c   �� 55   &   $��V.Arts��60   $��SemiBold"�6>   $��18(�6T   $��0 0 0 10q�6b   �� 56   &   $��G.Arts��60   $��SemiBold"�6>   $��18(�6T   $��0 0 0 10q�6b   57   #   �� 59   "   $��
560 50 0 0q�6-   .+�5:   &   �� $��+233262658209��60   $��SemiBold"�6E   $��18(�6[   $��0 0 0 10q�6i   �� 5;   &   $��+233265107727��60   $��SemiBold"�6E   $��18(�6[   $��0 0 0 10q�6i   �� 5<   &   $��+233240369071��60   $��SemiBold"�6E   $��18(�6[   $��0 0 0 10q�6i   5=   #   �� 5?   "   $��
705 50 0 0q�6-   .+�5@   &   �� $��AK-87365��60   $��SemiBold"�6@   $��18(�6V   $��0 0 0 10q�6d   �� 5A   &   $��AK-83947��60   $��SemiBold"�6@   $��18(�6V   $��0 0 0 10q�6d   �� 5B   &   $��AK-32648��60   $��SemiBold"�6@   $��18(�6V   $��0 0 0 10q�6d   5C   #   �� 5G   "   $	 
Horizontal=�6-   .+�5H   &   �� 
�������$��2 0 0 0q�6E   
������ $��10��6x   $��	170 0 0 0q�6�   �� 5I   &   
�������$��2 0 0 0q�6E   
������ $��10��6x   $��	120 0 0 0q�6�   �� 5J   &   
�������$��2 0 0 0q�6E   
������ $��10��6x   $��	130 0 0 0q�6�   �� 5K   &   
�������$��2 0 0 0q�6E   
������ $��10��6x   $��	100 0 0 0q�6�   �� 5L   &   
�������$��2 0 0 0q�6E   
������ $��10��6x   $��	140 0 0 0q�6�   5M   #   5N      5O      5P      5Q      5R      5S      5T      5U      