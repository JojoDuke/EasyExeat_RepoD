   M S B A M L   `   `   `  ����F  BNew_EZexeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:New_EZexeatNew_EZexeat  5   	   *    $New_EZexeat.ReturnMessageDialogueBox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:New_EZexeat  5   	     � WindowStyle$
  None=�5	   	    � WindowStartupLocation$ CenterScreen=�6    � AllowsTransparency . 
������  � Title$ ReturnMessageDialogueBox��5
   	   $	��150��6*   $	��300��67   .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension     Kind$ ExpandIn=�   Duration$ 0:0:0.15X�.��5   
   � -   5         �Name$ gridder��5   (   
������ .+�5      �� 
������ 
������ $��15q�6I    �� CornerRadius$ 20��6^   z�5      T� 5      -   5        borderTransform��5   )   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   	Direction$

 -436Q�6'      ShadowDepth$ 4Q�68      Opacity$	 0.5Q�6H      
BlurRadius$ 25Q�6V      Color$ Black��6f   ._�5      �� 
������ $ 20��62   
������ $��0q�6^   ._�5      �� 
�������$ 20��60   
������ ._�5      �� $��Center=�6%   $��Center=�6B   .+�5      �� -   5         ��Name$ itstext��5   (   $��14(�5   (   $��SemiBold"�5   (   $��0 0 0 10q�5   (   ���	#FFA8A8A8 �� TextAlignment$ Center=�5   (   �� 6@   $(�"Username or Password is incorrect.��6D   �� 6p   �� 6|   $� Please try again��6�   6�   �� 5!      -   5         ��Name$
 btnn��5"   %   $��OK��5!   %      OrangeButtonTemplate#��[  5#   %   $��SemiBold"�5$   %   $��20(�5%   %   $��	20 0 20 0q�5&   %    �� IsCancel . $��45��5*   %    � FocusVisualStyle 5(   %   Z� ��5)   %   Z� 5*   %   5+      5,      5-      5.      5/      50      51      