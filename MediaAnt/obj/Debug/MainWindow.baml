   M S B A M L   `   `   `  ����C  ?MediaAnt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MediaAntMediaAnt  5   	       MediaAnt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MediaAnt     5   	     � Title$  
MainWindow��5   	   $
��1024��6   $
��1280��6*   .��5	      � $��0,0,2,0q�6   $	��984��6   $	��Top=�6)   #��� ��6A    J� RenderTransformOrigin$ 	0.5,1.009&�6�   .+�5
   
   �� -   5        $
��Open��5
      $
��Left=�6    $��33��6;   $��	7,941,0,0q�6G   $	��Top=�6Z   $	��110��6r   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��33��60   $��	7,941,0,0q�6<   $	��Top=�6O   $	��331��6g    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF6016FF��6#   5      �� 5   
   -   5        $��slider��5      $
��Left=�6   $��	9,908,0,0q�6:   $	��Top=�6M   $
��1241��6e   $ 0.5,0.5&�6r   ���	#FF6016FF 5        5      z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.179Q�6&   T� 5      5      5      �� 5   
   -   5        $
��Left=�5   4   $��117,941,0,0q�6O   $	��Top=�6d   $	��113��6|   $��33��6�   ��6   �� *PlayButtonName+6�   �� 5   
   -   5        $
��Stop��5      $
��Left=�6    $��230,941,0,0q�6;   $	��Top=�6P   $	��108��6h   $��33��6t   $
��Bold"�6�   � 5   
   $��10,10,10,96q�6   .+�5       r� -   5         r�Name$ media��5        r� UnloadedBehavior$ Manual=�6*    � Cursor$ No��6~    r� LoadedBehavior$ Manual=�6�   	 r� Volume$	 5Q�6�   $ 0.5,0.5&�6�   $	��878��6�   $	��Top=�6�   
 J� OpacityMask
 5!      �� 5"       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5#      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5$      $ 	#FF6700FB��6'   $ 1Q�69   5%      z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+      T� 5,      5-       � ContextMenu 5/      �� 50      ���	#FFFB0E0E���	#FFF91212$��15(�6Q    52        53      55      56      �� 57   
   -   5         ��Name$ sliders��57      $
��Left=�6"   $��1008,941,0,0q�6=   $	��Top=�6S   $	��233��6k    � Maximum$ 1Q�6�    � Value$ 1Q�6�   $��33��6�    58        59      $ 	#FF6E11F5��6#   5;      5<      5=      