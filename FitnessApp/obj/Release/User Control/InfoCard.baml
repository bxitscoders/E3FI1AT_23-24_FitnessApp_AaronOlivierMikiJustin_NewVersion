   M S B A M L   `   `   `  ����   
FitnessApp&     FitnessApp.User_Control.InfoCard   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   -   $��infoCard��.��� -     �Name$
  grid��$	��8 0q�.+���  �� CornerRadius$ 20�����#7163ba$��60��$��60��$	��Top=�$��	0 -30 0 0q� K� ZIndex$ 1�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 3Q�   Opacity$	 0.3Q�   	Direction$	 270Q�   Color$ #7163ba��._�.  (MahApps.Metro.IconPacks.PackIconMaterial  $��30��$��30��
�������$��Center=�$��Center=�	   Kind	 �� 
 �� ElementName$
 infoCard�� �� Path$
 Icon��� -    ��Name$ border��$��1q����#7163ba$ 20������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� $

 grid��$ IsMouseOver� �� Value True.a���  � y�$ Visible=���  �� $
 infoCard��$ IsActive� True.a���  � y�$ Visible=��� 
�������$ 20�� �� Padding$ 10q�._��� .+���    
dotsButton#��[  .��  $	 DotsVertical=��� ���#5d5382$��16(�$
��Bold"�$��Center=�$��0 10 0 0q����� $
 infoCard��$ Title��� ���#958ead$��Center=�$��0 5 0 10q����� $
 infoCard��$
 Desc�� $	��7 0q� � ColumnDefinitions �� $��* ��� $��* �.+��� $��Progress�����#625986�� ���#625986$��1�� �� TextAlignment$ Right=����� $
 infoCard��$ 
Percentage���   SliderStyle2#���   �� IsSelectionRangeEnabled .  �� SelectionEnd �� *Value+$
 infoCard��� $��6 3 6 0q� �� $
��auto ��� $��* �.+��� ���#958ead$��Center=�$��11(����� $
 infoCard��$ 
BottomText��� $��1��$��Right=�  
cardButton#��[ ���� $
 infoCard��$
 Days�