   M S B A M L   `   `   `  ����D  @BelifeWPf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BelifeWPf	BelifeWPf  5   	       BelifeWPf.MainWindow   5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null6mah,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BelifeWPf     5   	     � Title$  
MainWindow��5
   	   $	��600��6   $
��1000��6)   (  "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .     IgnoreTaskbarOnMaximize . 
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   $	��600��5   	   $
��1000��6      ResizeBorderThickness$ 0q�6)    � 
ResizeMode$ NoResize=�6C      TitlebarHeight$ 0��6Y      	TitleCaps .  *	   #WindowButtonCommandsOverlayBehavior$	 Never=�6~   
 � WindowStyle$

 None=�6�   .��5      � .+�5   
   ��  �� CornerRadius$ 30��6   
�������6#   ,  &MahApps.Metro.Controls.MetroTabControl  5   
   -   5        $��TCPrincipal��5      
������ .@�5      )  #MahApps.Metro.Controls.MetroTabItem  $��prueba��6   $��682,74,-683,-73q�6/   .��5      � .+�5      ��    
LogoBeLife#���   6   $��Imagenes/BeLife-logo.png��6B   �� 5        BarraInferior#���  6   �� 5        BotonCurvo1#���  6   $��820,506,10,11q�6C   $��Limpiar ��6Z   �� 5        
BotonCurvo#���  6   $��629,506,201,11q�6B   $��	Eliminar ��6Z   �� 5      #���  6   $��442,507,388,10q�6B   $��
Modificar ��6Z   �� 5      #���  6   $��255,506,575,11q�6B   $��Guardar ��6Z   �� 5       
 Input1#���  6   $��442,90,304,431q�6>   ._�5      ��  
 Input2#���  6"   5       �� 5!      #���  6   $��442,150,304,371q�6>   ._�5"      �� #���  6"   5#      �� 5$      #���  6   $��442,212,304,309q�6>   ._�5%      �� #���  6"   5&      �� 5'      #���  6   $��442,274,304,247q�6>   ._�5(      �� $	��250��6#   
������ $��0q�6H   
�������*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ <Seleccione>��6t      WatermarkAlignment$ Center=�6�    J� SnapsToDevicePixels .  � Cursor$ Arrow��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   .@�5)      �� $
��hola��6*   
������ '  !MahApps.Metro.Controls.ItemHelper   DisabledForegroundBrush
 �����5+      5,      5-      �� 5.      #���  6   $��442,344,304,177q�6>   50      �� 51      #���  6   $��442,408,304,113q�6>   53      57      5?      5@      �� 5D   
   -   5        $��Btn_despliegaFly��5D   W     boton360#���  6   $��26��64   $��10,66,957,477q�6@   .��5E      ��   	Imagen360#���  6   $��Imagenes/Submit-01-WF.png��68   5F      �� 5J   
   -   5        $��Btn_CerrarApp��5J   4   #���  6   $��936,0,31,544q�6I   .��5K      �� #���  6   $��Imagenes/Cross Close.png��68   5L      �� 5P   
   -   5        $��
Btn_MinApp��5P   4   #���  6   $��24��6F   $��915,16,60,560q�6R   .��5Q      �� #���  6   $+��%Imagenes/CircledArrow Topleft -02.png��68   5R      #  MahApps.Metro.Controls.Flyout  5U   
   -   5          Name$	 fly��5U      
���   � J� Opacity$	 0.7Q�65   $
��0,72q�6C   ���	#FFD6D6D6$	��148��6h   .��5V      �� 5X      5Y      5a      5b      