   M S B A M L   `   `   `  ����L  HChatAppClientSide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ChatAppClientSide.ViewsChatAppClientSide.Views  5      "    ChatAppClientSide.Views.Item   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ChatAppClientSide.Views     5      -   5        $
��item��5      .��5	      ��   �� Padding$	  0 8q�6   ��5
   
   �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 0 0 3 0q�5      �� 5       � ��
 ���� 5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  � �� �#F1EFFB5   !   �� 5       � �� �#6F52F95   !   5      �� 5       �� Binding 6"   ��  �� ElementName$
 item��	 �� Path$	 IsActive�
 �� Value
 True5   "   .a�5      ��  � �� �#F1EFFB5   !   �� 5       � �� �#6F52F95    !   5!      5#      ._�5&   
   �  � ColumnDefinitions 5'      �� 5(      $
��auto �6#   �� 5)      $	��180 �6#   �� 5*      $��* �6#   .+�5-      �� 
������� �� CornerRadius$ 50��5.      $��23��5/      $��23��50      $��20 0 0 0q�51      ._�53      � .+�54      �� $��Center=�55       $��SemiBold"�56       $��Center=�57       $��14(�58       59      A� 5;      
���   ���5<      �� 5=       �� ImageSource$ \Assets\server2.png��6)   5?      5A      5B      �� 5D      $��Center=�6   $��1��5E      $��15 0 0 0q�5F      .+�5G      �� -   5         ��Name$
 name��5G      
�������$��17(�5I      $��SemiBold"�5J      5K      �� 5M      $ 50��6   $��20��5N      $��20��5O      $��2��5P      5Q      5S      5T      5U      