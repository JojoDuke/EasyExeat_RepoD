   M S B A M L   `   `   `  ����F  BNew_EZexeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:New_EZexeatNew_EZexeat  5          New_EZexeat.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:New_EZexeat     5        N� Title$  Page2��5	      .��5      � ���	#FF8F8FF9.+�5   
   �� ���	#FFF2F2F2$��100,34,100,56q�6(    �� CornerRadius$ 40��6?    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.4Q�6#      Color$ 	#FF3A3A3A��5   #      RenderingBias$ Quality=�5   #      ShadowDepth$ 12Q�5   #      
BlurRadius$ 30Q�5   #   ._�5      �� -   5         ��Name$
 siTB��5      $��35(�5      $��Segoe UI Semibold)�5      	 �� TextAlignment$	 Center=�5      ���	#FF8F8FF9$��Center=�5      $��	0,0,0,379q�5      $	��760��5      $��Create a New Account��5      66   5       �� 5!   
   -   5        $ plsTB��5!      $��Segoe UI Semibold)�5"      $��12(�5#      ���	#FFB6B6EC$��100,124,100,390q�5%      $	 Center=�5&      �� 5'      $�*Please fill in all the��6   �� 5(      �� 5)      $�blank spaces��6   5*      �� 5.   
   -   5        
 ��Name$
 firstScroll��5.      $	��200��6,   $	��550��6<   $
��Auto=�6K   $
��Auto=�6n   .��5/      �� $��Center=�6   $��Center=�64   $	 Center=�6Q   $��
20 -40 0 0q�6r   .+�51      �� -   5         ��Name$ tbStudentName��53         TextBoxPlaceholder#��[  51      
 � Tag$ Name of Student��52      $	��350��54      �� 56      -   5        $ tbSchoolName��58      #��[  56      $ Name of School��57      $	��350��59      �� 5;      -   5        $ tbHouseName��5=      #��[  5;      $ Name of House��5<      $	��350��5>      �� 5@      -   5        $ tbProg��5B      #��[  5@      $ 	Programme��5A      $	��350��5C      �� 5E      -   5        $ tbPhoneNumber��5G      #��[  5E      $ Phone Number��5F      $	��350��5H      5I      �� 5K      -	   5        $ 	tbAddress��5M      #��[  5K      $ Home Address��5L      $	��350��5N      G� 5P      -
   5         G�Name$ 
pbPassword��5R        PasswordBoxPlaceholder#��[ 5P      $ Password��5Q      $	��350��5S      �� 5V      -   5         ��Name$ 	ErnollBtn��5V      $��Center=�5X      $��Center=�5Y      $��20(�5Z      $��Segoe UI)�5[      $��Enroll Fingerprint��5\      $
��Bold"�5]      $��0 0 0 0q�5^      $��40,25,40,40q�5_       � FocusVisualStyle 5W      Z� 5`   $   �� 5a      -   5        $��	LBLSTATUS��5c      $��20(�5d      $��Segoe UI)�5e      $'��!Successfully Enrolled Fingerprint��5f      $��40,-30,40,40q�5g      $y�Hidden=�5h      $
��Bold"�5i      5k      5n      5o      �� 5r   
   -   5        $ bkBtn��5r        
AntiButton#��[ 6    $��Center=�5t      $��Center=�5u      $��20(�5v      $��Segoe UI)�5w      $
��Bold"�5x      $��116,56,722,455q�5y       5s      Z� 5z   '   �� 5|   
   -   5        $ 	SubmitBtn��5|        RoundedButtonTemplate#��[ 6$   $��SUBMIT��5}      $��25(�5~      $��Segoe UI)�5      $
��Bold"�5�      $��Center=�5�      $��325,430,325,72q�5�       5�      Z� 5�   +   �� 5�   
   $
��Left=�6   $	��580��5�      $��689,0,-494,-20q�5�      $	��Top=�5�      $	��765��5�      $-��'Images\Backgrounds\emoji-background.png��5�       K� ZIndex$ -1��5�      �� 5�   
   $
��Left=�6   $	��580��5�      $��-221,-10,0,-10q�5�      $	��Top=�5�      $	��521��5�      $-��'Images/Backgrounds/emoji-background.png��5�      $ -1��5�      �� 5�   
   $��3��6   ���#e6e6e6$	��100q�5�      $��232,116,232,441q�5�      �� 5�   
   ���#e6e6e6$��3��5�      $	��100q�5�      $��232,395,232,130q�5�      5�      5�      