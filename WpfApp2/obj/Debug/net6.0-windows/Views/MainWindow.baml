   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1024��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o    � 	Resources 5
      &   System.Windows.Controls.DataGrid �� 
TargetType   ScrollThumbs �� Property �� Value �� 
TargetType �Name	 ��Name
 �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle�� 5   
   %8	  '        &	  !     '�� e    �� 5      "  6   5      �� 5      " n�6)   .�5      ��  � �� 5      �� 5      " n�6*   .R�5      � $
 Grid��6#   .+�5   "   �� $��Stretch=�6,   $��Stretch=�6J   $
��Auto��6f   $
��Auto��6s   
������ 6�   �� 5   "   $	 
Rectangle1��6)   $
 10��6=   $��Stretch=�6O   $��Stretch=�6m   $
��Auto��6�   $
��Auto��6�   #��z��6�   5       5      P� 5   "    �@�Tag$ 
Horizontal��69   . �5   &   �� $ 
Rectangle1��6-    � ��$
 Auto��6V   �� 5   &   $ 
Rectangle1��6-    � ��$ 7��6W   5   #   5      5       5!      �� 5$      " ��6/   .�5%      ��  �@��IsFlicksEnabled$ false��6;   �� 5&       � ��
 �����6/   �� 5'       � ��
 �����6/   �� 5(       � ��$ 10��6*   �� 5)       � �� 5*      �� 5+      " ��6*   .R�5,      � $ GridRoot��6#   $��19��65   ��6@   Z� .+�5-   "   ]� $ 
PART_Track��6(   $��0��6<   $
��true��6I   $|�false��6d    5.   &   n� 5/   *   $ Thumb��60   #��z��6?   #���   6i    51   &   �� 52   *   $ PageUp��67   $��ScrollBar.PageDownCommand��6G   $ 0Q�6k   $|�false��6w    54   &   �� 55   *   $ PageDown��67   $��ScrollBar.PageUpCommand��6I   $ 0Q�6k   $|�false��6w   57   #   58       5:      P� 5;   "   $ Thumb��6*    �@J�IsMouseOver$
 true��6T   . �5<   &   �� # �  6-   $ Thumb��6Y    � ��6l   5=   #   P� 5>   "   $ Thumb��6*    �@n�
IsDragging$
 true��6S   . �5?   &   �� # �  6-   $ Thumb��6Q    � ��6d   5@   #   P� 5B   "    � {�$ false��6?   . �5C   &   �� $ Thumb��6-    � y�$ 	Collapsed=�6V   5D   #   P� 5E   "    �@��Orientation$ 
Horizontal=�6A   . �5F   &   �� $ GridRoot��6-    �@�LayoutTransform 5G   *   �� 5H   .   $	 -90Q�6>   5J   '   �� 5K   &   $ 
PART_Track��6-    �@�LayoutTransform 5L   *   �� 5M   .   $	 -90Q�6>   5O   '   �� 5P   &    � ��$
 Auto��6>   �� 5Q   &    � ��$ 12��6?   �� 5R   &   $ Thumb��6-    �@�Tag$ 
Horizontal��6O   �� 5S   &   $ PageDown��6-    � ��$ ScrollBar.PageLeftCommand��6V   �� 5T   &   $ PageUp��6-    � ��$  ScrollBar.PageRightCommand��6T   5U   #   5W      5Y      5Z      5[      .��5_      � -   5        $ MainGrid��5_       � ColumnDefinitions 5`   
   �� 5a      $	��200 �6   �� 5b      $��* �6    � RowDefinitions 5d   
   �� 5e      $��30 �6   �� 5f      $��* �6   .+�5l   
   � $��1��6   ��5m      �� 5n       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5o      �  � Color$ 	LightGray��6#    � Offset$ 1Q�65   � 5p      $ 	#FFE6E6E6��6#   5q       5s      �� 5t      $	��100 �6    �� 5u      $��* �6     J� Effect 5w      3  -System.Windows.Media.Effects.DropShadowEffect  5x         
BlurRadius$ 20Q�6#       Color$  	#FFDEDEDE��63   !   RenderingBias$! Quality=�6E   "   ShadowDepth$" 1Q�6]   .+�5{      � ���	#FFA46FE4.+�5|      �� $��Managment Database��6   $��Center=�66   $��Center=�6S   $��WS Simple Gallifreyan)�6n   
�������$��16(�6�   5}      �� 5      $��Center=�6   $��1��64   .+�5�      �� -   5        $��	TableName��5�      $��0,0,0,30q�5�      ���	#FF8522BD$��15(�5�      $��Hidden=�5�      $��Center=�5�      $	��100��5�      $��30��5�      )  #MaterialDesignThemes.Wpf.HintAssist#   Hint$# Tables��5�      $��Center=�6C   $��72��5�      ��5�      �� *Tables+5�      �� 5�      $��10q�6j   $��50��6v   ���	#FF8522BD���	#FF8522BD��6   �� *
GetCommand+��68   �� $ �� ElementName$$ MainGrid��.��5�      �� $��Center=�6    $	��Get��6=   $��Champagne & Limousines)�6H   5�      �� 5�      $��50��6m   $��10q�6y   ���	#FF8522BD���	#FF8522BD��6   �� *UpdateCommand+��6;   �� $$ MainGrid��.��5�      �� $��Center=�6    $��Update��6=   $��Champagne & Limousines)�6K   5�      �� 5�      $��50��6m   $��10q�6y   ���	#FF8522BD���	#FF8522BD��6   �� *InsertCommand+��6;   �� $$ MainGrid��.��5�      �� $��Center=�6    $��Insert��6=   $��Champagne & Limousines)�6K   5�      �� 5�      -   5        $��	DeleteBtn��5�   <   $��50��6   $��10q�6�   ���	#FF8522BD���	#FF8522BD��6   �� *DeleteCommand+��6M   �� $$ MainGrid��.��5�      �� $��Center=�6    $��Delete��6=   $��Champagne & Limousines)�6K   5�      5�      5�      � 5�   
   -   5        $ GridBarraTitulo��5�      $��2��6(   ���	#FF8522BD.+�5�      �� % �� Orientation$% 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5�      ��  0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6   $��25��6_   $��25��6j   
���������6v   Z� ��6�   Z� .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  &   Kind$
& Bell=�6.   5�      �� 5�      #��[ 6   $��25��6_   $��25��6j   
���������6v   Z� ��6�   Z� .��5�        $& Account=�6.   5�      �� 5�      -   5        ' ��Name$' ButtonFechar��5�      #��[ 6/   $��25��6u   $��25��6�   
���������6�   Z� ��6�   Z� .��5�        $& Power=�6.   5�      5�      5�      � 5�   
   $��1��6   $��1��6   $��50q�6-    5�      �� 5�      $��* �6    �� 5�      $
��0.1* �6    .+�5�        -   5        $��DataGrid��5�   }   (   HeadersVisibility$	( All=�6I   )   CanUserAddRows$
) True��6�   *   
IsReadOnly$* False��6�   ��6+   �� *datas+6�   �� 5�      -   5        $��AddingNewItem��5�   )   $y�Hidden=�6   ��6>   �� *AddingNewItem+�� 5�      -   5        $��	errorCode��5�   E   $��Center=�6   $y�Hidden=�61   $��Center=�6V   $��14(�6q   
���  ��$��1��6�   $��asdasdasdasdasdasda��6�   5�      5�      5�      