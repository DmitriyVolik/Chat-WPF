   M S B A M L   `   `   `  ����  Chat    Chat.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$
  Chat��5   	   $	��450��6   $	��500��6#   $	��300��5   	   $	��250��5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6"   $��2��62   .+�5      �� $��15(�6   $��Arial)�6"   $
��Bold"�65   $��
Логин��6G   $��Center=�6W   �� 5       �� 	MaxLength$ 20��65   $��12(�6D   $��150px��6R   $��20��6`   $��Center=�6l   ��6   �� *CurrentLogin+6l   �� 5      $��15(�6   $��Arial)�6"   $
��Bold"�65   $��Пароль��6G   $��Center=�6X   G� 5      -   5        $��MyPasswordBox��5       G� 	MaxLength$ 20��6/   $��12(�6>   $��150px��6L   $��20��6Z   $��Center=�6f   5      �� 5   
   $��1��6   $
��Bold"�6   $��15(�60   $��Arial)�6>   $��0��6Q   $	��100��6a   $��50��6m   $��Регистрация��5      ��6'   �� *RegistrationBtn+��6L   ��  �� ElementName$ MyPasswordBox���� 5   
   $��1��6   $
��Bold"�6!   $��15(�63   $��Arial)�6A   $	��100��6T   $��1��6`   $��50��6m   $��Вход��5      ��6    �� *	SignInBtn+��6?   �� $ MyPasswordBox��5      5       