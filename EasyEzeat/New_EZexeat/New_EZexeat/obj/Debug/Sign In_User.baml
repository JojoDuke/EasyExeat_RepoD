   M S B A M L   `   `   `  ����F  BNew_EZexeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:New_EZexeatNew_EZexeat  5          New_EZexeat.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:New_EZexeat     5        N� Title$  
User_LogIn��5	       N� ShowsNavigationUI .  .��5      � ���	#FF8F8FF9.+�5   
   �� ���	#FFF2F2F2$��300,34,302,56q�6(    �� CornerRadius$ 40��6?    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.4Q�6#      Color$ 	#FF3A3A3A��5   #      RenderingBias$ Quality=�5   #      ShadowDepth$ 12Q�5   #      
BlurRadius$ 30Q�5   #   ._�5      � .+�5      �� -   5        	 ��Name$
	 siTB��5      $��30(�6*   $��Segoe UI Semibold)�68   
 �� TextAlignment$
 Center=�6W   ���	#FF8F8FF9$��
0,38,0,-24q�6�   �� 6�   $�Sign into your ��6�   �� 6�   �� 6�   $�account��6�   6�   5      5      �� 5   
   $��3��6   $	��318��5      ���#e6e6e6$	��100q�5!      $��321,150,321,407q�5"      �� 5$   
   $��3��6   $	��318��5%      ���#e6e6e6$	��100q�5'      $��321,379,321,178q�5(      �� 5+   
   -   5         ��Name$ UserSignInBtn��5+         RoundedButtonTemplate#��[  6(   $��SIGN IN��5,      $��Center=�5-      $��Center=�5.      $��25(�5/      $��Segoe UI)�50      $
��Bold"�51      $��59��53      $��483,430,325,72q�54       � FocusVisualStyle 52      Z� 55      �� 58   
   -   5        $ bkBtn��58        AnotherButton#��[ 6    $��Center=�5:      $��Center=�5;      $��25(�5<      $��Segoe UI)�5=      $
��Bold"�5>      $��59��5?      $��320,430,496,72q�5@       59      Z� 5@   )   �� 5B   
   -   5        $ FingerPrintBTN��5B      $��Signin with Fingerprint��5C      $��Center=�5F      $��Center=�5G      $��16(�5H      $��Segoe UI Semilight)�5I      $��28��5J      $��Center=�6   $	��Top=�5K      $��331,370,344,0q�5L      $	��305��5M      $��0 0 0 0q�5N       5D      Z� 5N      �� 5P   
   -   5        $ 	signupBtn��5P        	rekButton#��[ 5Q      $��Center=�5T      $��Center=�5U      $��16(�5V      $��Segoe UI Semilight)�5W      $��28��5X      $��Center=�6   $	��Top=�5Y      $��321,396,334,0q�5Z      $	��305��6(    5R      Z� 5Z   (   �� 5]   
   $��Student Name��6   ���#b3b3b3$��20(�5_      $	��Top=�5`      $��Center=�5a      $	��144��5b      $��408,172,408,0q�5c      $
 Center=�5d      $��34��5e      �� 5g   
   -   5         ��Name$
 tbID��5k      $��Center=�5g      $��Medium"�5h       �� TextWrapping$
 Wrap=�5i        coolioTextBox#��[ 5j      $��44��5l      $��10q�5m      $	��Top=�5o      $	��250��5p      $��356,196,354,0q�5q      �� 5t   
   $��Password��6   ���#b3b3b3$��20(�5v      $	��Top=�5w      $��Center=�5x      $
 Center=�5y      $	��144��5z      $��408,279,408,0q�5{      G� 5}   
   -   5         G�Name$ PB��5~      $��Center=�5}        coolioTextBox1#��[ 5      $��45��5�      $��16(�5�      $	��Top=�5�      $��10q�5�      $	��250��5�      $��356,314,354,0q�5�      ���	#FFF2F2F2 G� SelectionBrush
 �   � J� RenderTransformOrigin$ 0.5,0.5&�5�      $
��Bold"�5�      z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�       �� Angle$ 359.882Q�6&   T� 5�      5�      ��5�      �� 5�       �� EndPoint$
 0,20&�6&    � MappingMode$ Absolute=�66    �� 
StartPoint$	 0,0&�6M   .��5�      �  � Color$ 	#FFABADB3��6#    � Offset$
 0.05Q�65   � 5�      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5�      $ 	#FFB3B3B3��6#   $ 1Q�65   5�      5�      �� 5�   
   $
��Left=�6   $	��560��6+   $��663,0,-468,0q�68   $	��Top=�6N   $	��765��6f   $-��'Images\Backgrounds\emoji-background.png��6r   �� 5�   
   $
��Left=�6   $	��560��6+   $��-252,-10,0,0q�68   $	��Top=�6N   $	��765��6f   $-��'Images/Backgrounds/emoji-background.png��6r   5�      5�      