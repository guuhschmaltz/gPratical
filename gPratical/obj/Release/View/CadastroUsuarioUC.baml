   M S B A M L   `   `   `  ���� D  @gPratical, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:gPratical.ViewgPratical.View  &     gPratical.View.CadastroUsuarioUC   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:gPratical.View     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  :
extensions)using:Microsoft.Toolkit.Uwp.UI.Extensions     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .��� .+��  � ColumnDefinitions �� �� ��  � RowDefinitions �� �� �� �� �� .+��� -    ��Name$ txtNome��$��Bottom=�$
��Left=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nome Completo�� �� 	MaxLength$	 100�� � ToolTip$ Insira seu nome completo.��$��0��$��2��$��5q� % !MaterialDesignFloatingHintTextBox#��[ $��1��(  "System.Windows.Controls.DatePicker  -     Name$ dtpDataNascimento��$��Bottom=�$ Data de Nascimento��$# Insira sua data de nascimento�� ( $MaterialDesignFloatingHintDatePicker#��[ $��2��$��5q�$��2���� -   	 ��Name$	 	cmbGenero��$��Bottom=�$
��Left=�$ Insira seu genero��$��3��$ Gênero��$��3��$��1��$��5q� & "MaterialDesignFloatingHintComboBox#��[ $��10������ *#!LongListToTestComboVirtualization+�� -   $ txtCargo��$
��Left=�$ Cargo��$	 100��$ Insira seu cargo��$��1��$��1��$��Bottom=�$��5q�#��[ $��4���� -   $	 cmbSetor��$
��Left=�$ Setor��$0 *Insira o setor do usuario a ser cadastrado��$��1��$��3��$��Bottom=�$��5q�#��[ $��5������ *#!LongListToTestComboVirtualization+�� -   $ txtOutroGenero��$	��Top=�$
��Left=�$  ��$  ��$��4��$��3��$��1��$��5q�$y�	Collapsed=��� -   $ 	txtCidade��$��Bottom=�$
��Left=�$ Cidade��$ 50��$ Insira sua cidade��$��3��$��0��$��1��$��5q�#��[ $��8���� -   $ 	txtBairro��$��Bottom=�$
��Left=�$ Bairro��$ 50��$ Insira seu bairro��$��3��$��1��$��1��$��5q�#��[ 
 K� ZIndex$
 9��$��9���� -	   $ txtEndereco��$��Bottom=�$
��Left=�$ Endereco��$	 150��$ Insira seu endereco��$��2��$��0��$��2��$��5q�#��[ $��6���� -
   $	 	cmbEstado��$��Bottom=�$
��Left=�$ Estado��$ Insira seu estado��$��2��$��3��$��1��$��5q�#��[ $��7������ *#!LongListToTestComboVirtualization+�� -   $ txtTelefone��$��Bottom=�$
��Left=�$ Telefone��$	 100��$ Insira seu telefone��$��1��$��0��$��1��$��5q�#��[ $��3���� $
��Left=�$	��Top=� �� Orientation$ 
Horizontal=�$��2��.+��� -    ��Name$ 	btnEditar�� $  MaterialDesignRaisedAccentButton#��[ 
�������
����� �$	��100��$��40��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 	0 0 25 25��$+ %Cadastrar um novo usuário no sistema��$��Editar��$	��5,0q��� -   $ 	btnLimpar��#��[ 
�������
����� �$	��100��$��40��$ 	0 0 25 25��$8 2Cancelar o cadastro e voltar para a pagina inicial��$��Limpar��$	��5,0q��� $��Right=�$��Bottom=�$ 
Horizontal=�$��2��$��3��$��4��.+��� -   $ btnCadastrar��#��[ 
�������
����� �$	��100��$��40��$ 	25 25 0 0��$+ %Cadastrar um novo usuário no sistema��$��	Cadastrar��$	��5,0q�$��2��$��3��$��4���� -   $ btnCancelar��#��[ 
�������
����� �$	��100��$��40��$ 	25 25 0 0��$8 2Cancelar o cadastro e voltar para a pagina inicial��$��Cancelar��$	��5,0q�$��2��$��3��$��4��