   M S B A M L   `   `   `  ���� D  @gPratical, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:gPratical.ViewgPratical.View  *    $gPratical.View.CadastroEquipamentoUC   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:gPratical.View     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  $��Stretch=�$��Stretch=�.��� .+��  � ColumnDefinitions �� �� ��  � RowDefinitions �� �� �� �� .+��� -    ��Name$ cmbTipo��$��Bottom=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Tipo�� � ToolTip$" Insira o tipo do equipamento��$��0��$��1��$��5q� & "MaterialDesignFloatingHintComboBox#��[ $��3������ *#!LongListToTestComboVirtualization+�� -    ��Name$ txtMarca��$��Bottom=�$
��Left=�$ Marca�� �� 	MaxLength$	 100��$ Insira o nome da marca��$��1��$��1��$��5q� % !MaterialDesignFloatingHintTextBox#��[ $��4���� -   $ txtSN��$��Bottom=�$
��Left=�$ (S/N):��$	 100��$/ )Insira o número de série do equipamento��$��0��$��1��$��1��$��5q�#��[ $��6���� -   $ txtPotencia��$��Bottom=�$
��Left=�$ 
Potência:��$	 100��$' !Insira a potência do equipamento��$��0��$��2��$��1��$��5q�#��[ $��9���� -   $ 	txtModelo��$��Bottom=�$
��Left=�$ Modelo��$	 100��$$ Insira o modelo do equipamento��$��2��$��1��$��5q�#��[ $��5���� -   $ cmbVoltagemEntrada��$��Bottom=�$ Voltagem de Entrada��$% Selecione a voltagem de Entrada��$��1��$��1��$��1��$��5q�#��[ $��7������ *#!LongListToTestComboVirtualization+�� -   $ cmbVoltagemSaida��$��Bottom=�$ Voltagem de Saída��$# Selecione a voltagem de Saida��$��2��$��1��$��5q�#��[ $��8������ *#!LongListToTestComboVirtualization+�� -   $ cmbSetor��$��Bottom=�$ Setor��$6 0Selecione o Setor onde o equipamento se encontra��$��3��$��2��$��1��$��5q�#��[ $��11������ *#!LongListToTestComboVirtualization+�� -	   $ txtLocal��$	��Top=�$
��Left=�$ Local��$	 100��$< 6Insira o local onde o equipamento se encontra no setor��$��3��$��3��$��1��$��5q�#��[ $y�	Collapsed=�(  "System.Windows.Controls.DatePicker  -
   	  Name$	 dtpValidade��$. (Insira a data de validade do equipamento��$��Bottom=�$ Validade�� ( $MaterialDesignFloatingHintDatePicker#��[ $��1��$��2��$��5q�$��10���� $
��Left=�$	��Top=�
 �� Orientation$
 
Horizontal=�$��2��.+��� -    ��Name$ 	btnEditar�� $  MaterialDesignRaisedAccentButton#��[ 
�������
����� �$	��100��$��40��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 	0 0 25 25��$&  Editar um equipamento no sistema��$��Editar��$	��5,0q�$��1���� -   $ 	btnLimpar��#��[ 
�������
����� �$	��100��$��40��$ 	0 0 25 25��$ Limapr todos os campos��$��Limpar��$	��5,0q�$��2���� $��Right=�$��Bottom=�$
 
Horizontal=�$��2��$��3��$��4��.+��� -   $ btnCadastrar��#��[ 
�������
����� �$	��100��$��40��$ 	25 25 0 0��$+ %Cadastrar um novo usuário no sistema��$��	Cadastrar��$	��5,0q�$��2��$��3��$��4��$��12���� -   $ btnCancelar��#��[ 
�������
����� �$	��100��$��40��$ 	25 25 0 0��$8 2Cancelar o cadastro e voltar para a pagina inicial��$��Cancelar��$	��5,0q�$��2��$��3��$��4��$��13��