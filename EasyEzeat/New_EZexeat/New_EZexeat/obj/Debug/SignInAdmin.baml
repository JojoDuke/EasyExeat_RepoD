   M S B A M L   `   `   `  ����F  BNew_EZexeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:New_EZexeatNew_EZexeat  5          New_EZexeat.SignInAdmin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:New_EZexeat     5        N� Title$  SignInAdmin��5	       � 	Resources 5
       
  Color1 
 Color2 
 Color3 
 Color4 
 Color5 
 Color6��%  &	        &	 !     &	 B     &	 c     &	 �     &	 �     ��5   
   	#FFF7B131��6*   ��5   
   	#FFF7B131��6*   ��5   
   	#FF989898��6*   ��5   
   	#FFF7B131��6*   ��5   
   	#FFF7B131��6*   ��5   
   Transparent��6,   5      .��5      � ���	#FFF7B131$��	-10,0,0,0q�6"   .+�5   
   �� ���	#FFF2F2F2$��300,25,302,67q�6(    �� CornerRadius$ 40��6?    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.4Q�6#      Color$ 	#FF3A3A3A��5   #      RenderingBias$ Quality=�5   #      ShadowDepth$ 12Q�5   #      
BlurRadius$ 30Q�5   #   ._�5      �� -   5        	 ��Name$
	 siTB��5      $��30(�6&   $��Segoe UI Semibold)�64   
 �� TextAlignment$
 Center=�6S   $��
0,30,0,-38q�6j   ��5      �� 5        �� Color# �  6&   �� 5!   )   $�Sign into your ��6-   �� 6F   �� 6R   $�account��6V   6h   5"      �� 5$   
   $��3��6   $	��318��5%      ���#e6e6e6$	��100q�5'      $��326,142,326,415q�5(      �� 5*   
   $��3��6   $	��318��5+      ���#e6e6e6$	��100q�5-      $��326,377,326,180q�5.      �� 50   
   -   5         ��Name$ Siadmin��50       	 admin#��[ 6"   $��25(�51      $��Segoe UI)�52      $
��Bold"�53      $��59��54      $��496,411,312,90q�55      ��56      �� 57      # �   6"   59      �� 5;   
   -   5        $ 
bkBtnAdmin��5;        
BackOrange#��[ 6%   $��Center=�5<      $��Center=�5=      $��25(�5>      $��Segoe UI)�5?      $
��Bold"�5@      $��59��5A      $��310,411,498,90q�5B      ��5C      �� 5D      $ 	#FFF9B230��6"   ��5F      �� 5G      $ 	#FFF7B131��6"   5I      �� 5K   
   -   5        $ signupBtnAdmin��5K        	rekButton#��[ 5L      $��Center=�5M      $��Center=�5N      $��16(�5O      $��Segoe UI Semilight)�5P      $��21��5Q      $��Center=�6   $	��Top=�5R      $��328,385,327,0q�5S      $	��305��6(   64   �� 5V   
   $��	User Name��6   ���#b3b3b3$��20(�5X      $	��Top=�6"   $��Center=�6:   $	��144��6W   $��413,181,413,0q�6c   $
 Center=�6z   $��34��6�   �� 5Y   
   -   5         ��Name$ firstTextBox��5Z      $��Center=�5Y       	 coolioTextBox#��[	 5[      $��26��5\       �� TextWrapping$
 Wrap=�5]      $	��Top=�5^      $	��250��5_      $��360,220,360,0q�5`       J� RenderTransformOrigin$ 0.5,0.5&�6)   �� 5c   
   $��Password��6   ���#b3b3b3$��20(�5e      $	��Top=�6"   $��Center=�6:   $
 Center=�6W   $	��144��6n   $��413,287,413,0q�6z   G� 5f   
   -   5         G�Name$ secondTextBox��5h      $��Center=�5f       
 coolioTextBox1#��[
 5g      $��40��5i      $��16(�5j      $	��Top=�5k      $��10q�5l      $	��250��5m      $��360,317,360,0q�5n      ���	#FFF2F2F2 G� SelectionBrush
 �   �$ 0.5,0.5&�6W   $
��Bold"�6w   z�5o      V� 5p      .~�5q      �� �� 5r      �� 5s       �� Angle$	 360Q�6&   T� 5t      5u      ��5w      �� 5x       �� EndPoint$
 0,20&�6&    � MappingMode$ Absolute=�66    �� 
StartPoint$	 0,0&�6M   .��5y      �  � Color$ 	#FFABADB3��6#    � Offset$
 0.05Q�65   � 5z      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5{      $ 	#FFB3B3B3��6#   $ 1Q�65   5|      5~      �� 5   
   $
��Left=�6   $	��560��6+   $��663,0,-468,0q�68   $	��Top=�6N   $	��765��6f   $-��'Images\Backgrounds\emoji-background.png��6r   �� 5�   
   $
��Left=�6   $	��547��6+   $��-213,13,0,0q�68   $	��Top=�6M   $	��513��6e   $-��'Images/Backgrounds/emoji-background.png��6q   5�      5�      