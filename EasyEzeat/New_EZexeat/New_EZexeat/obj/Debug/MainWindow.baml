   M S B A M L   `   `   `  ����F  BNew_EZexeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:New_EZexeatNew_EZexeat  5   	       New_EZexeat.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:New_EZexeat     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Icon$ Images/Logo/ezex_256.ico��5   	    � Title$ 
Easy Exeat��5
   	   $	��560��6   $	��960��6)    � 
ResizeMode$ CanMinimize=�65   .��5      � ���	#FF8E8FF9 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$
 img1��5      $��Images/ExeatLogo3.png��5      $	��128��5      $	��128��5      $��	0 0 0 395q�5      �� 5   
   -   5         ��Name$ wlduTB��5      $��Center=�6$   $
��Wrap=�6A   $	��Top=�6U   $��18(�6m   $&�� Would you like to Log In as a...��6{    �� TextAlignment$ Center=�6�    �� 
LineHeight$ 24��6�   {�.  $	��280��6�   $��336,193,336,0q�6�   �� 5   
   -   5        $ or_anTB��5      $��Or an��6%   $��18(�62   ���	#FFF2F2F2$��Segoe UI Semibold)�6W   $��452,313,-452,-313q�6v   $��4��6�   �� 5   
   -   5        	 ��Name$	 userBtn��5         RoundedButtonTemplate#��[  5      $��390,244,390,231q�5      $��20(�5!      $
��Bold"�5"      
 � FocusVisualStyle
 5       Z� ��5$      Z� .��5%      �� $��Center=�6   $
��Wrap=�5&      $
��USER��5'      $	��Top=�5)      $
��Bold"�5*      $��24(�5+      $ Center=�5,      ���	#FFF2F2F2$��0,0,0,0q�5.      
 5(      Z� 5.      5/      �� 52   
   -   5        $	 adminBtn��52      #��[  53      $��54��54      $��390,360,390,115q�56      $��20(�57      $
��Bold"�59      
 58      Z� .��5;      �� $��Center=�6   $
��Wrap=�5<      $��ADMIN��5=      $	��Top=�5>      $
��Bold"�5?      $��24(�5@      $ Center=�5A      ���	#FFF2F2F2$��0,0,0,0q�5C      5D      �� 5F   
   -   5         ��Name$ 
lineBorder��5F      $��2q�5G      $��Center=�5H      $��2��5I      $	��Top=�5J      $	��750��5K      ���	#FF9AA4E6$��100,466,102,0q�5M      �� 5P   
   -   5        $
 ezTB��5P      $*��$Easy Exeat© by Bhyte Softwares 2019��5Q      ���	#FFE6E6E6$��Segoe UI Semilight)�5S      $��17(�5T      $��101,473,-101,-472q�5U      $��4��5V      �� 5X   
   -   5        $ Version��5X      $��Alpha Version 2.9.4��5Y      ���	#FFE6E6E6$��Segoe UI Semilight)�5[      $��17(�5\      $��706,473,-706,-472q�5]      $��4��5^      �� 5a   
   -	   5        $ welkie��5a      $��3q�5b      ���	#FFF2F2F2$��323,140,317,346q�5d       �� CornerRadius$ 25��5e      ._�5g      �� $��Welcome to Easy Exeat��6   $��17(�5h      $
��Bold"�5i      $��Center=�5j      $��Center=�5k      ���	#FFF2F2F25l      5m       � 5o   	   -
   5          �Name$ 	mainFrame��5o        � NavigationUIVisibility$ Hidden=�5p      $��10,-10,-10,9.75q�5r      ��5s      Z� 5t      5u      