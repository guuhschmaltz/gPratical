using gPratical.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gPratical.View
{
    /// <summary>
    /// Interação lógica para CadastroUsuarioUC.xam
    /// </summary>
    public partial class CadastroUsuarioUC : UserControl
    {
        public CadastroUsuarioUC()
        {
            InitializeComponent();
            CarregarCmbItens();
        }


        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Usuario.Unit C = new Usuario.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                MessageBox.Show("Classe foi inicializada sem erros", "gPratical");
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "gPratical", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cadastro não inicializado com sucesso, preencha todos os campos", "gPratical", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }


        Usuario.Unit LeituraFormulario()
        {
            Usuario.Unit C = new Usuario.Unit();
            C.Nome = txtNome.Text;
            C.DataDeNascimento = Convert.ToDateTime(dtpDataNascimento.SelectedDate);
            C.Telefone = txtTelefone.Text;
            C.Cargo = txtCargo.Text;
            C.Setor = cmbSetor.SelectedValue.ToString();
            C.Endereco = txtEndereco.Text;
            C.Estado = cmbEstado.SelectedValue.ToString();
            C.Cidade = txtCidade.Text;
            C.Bairro = txtBairro.Text;
            var genero = cmbGenero.SelectedValue.ToString();
            var OutroGenero = txtOutroGenero.Text;
            if (genero == "Outro")
            {
                C.Genero = OutroGenero;
            }
            else
            {
                C.Genero = genero;
            }
            return C;
        }



        private void cmbGenero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Genero genero = (Genero)cmbGenero.SelectedItem;

            if (genero.Nome == "Outro")
            {
                txtOutroGenero.Visibility = Visibility.Visible;
                txtOutroGenero.Text = "";
            }
            else
            {
                txtOutroGenero.Text = "";
                txtOutroGenero.Visibility = Visibility.Collapsed;
            }

        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimpaFormulario();
        }

        private void LimpaFormulario()
        {
            txtBairro.Text = "";
            txtCargo.Text = "";
            txtCidade.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtOutroGenero.Text = "";
            txtOutroGenero.Visibility = Visibility.Collapsed;
            cmbEstado.SelectedValue = "";
            cmbGenero.SelectedValue = "";
            cmbSetor.SelectedValue = "";
            dtpDataNascimento.SelectedDate.GetValueOrDefault();
        }

        private void CarregarCmbGenero()
        {
            var generos = Genero.GetGeneros();

            cmbGenero.ItemsSource = generos;
            cmbGenero.DisplayMemberPath = "Nome";
            cmbGenero.SelectedValuePath = "Nome";
        }
        private void CarregarCmbSetor()
        {
            var setores = Setor.GetSetores();

            cmbSetor.ItemsSource = setores;
            cmbSetor.DisplayMemberPath = "Nome";
            cmbSetor.SelectedValuePath = "Nome";
        }

        private void CarregarCmbEstado()
        {
            var setores = Estado.GetEstados();

            cmbEstado.ItemsSource = setores;
            cmbEstado.DisplayMemberPath = "Nome";
            cmbEstado.SelectedValuePath = "Nome";
        }
        private void CarregarCmbItens()
        {
            CarregarCmbGenero();
            CarregarCmbSetor();
            CarregarCmbEstado();
        }
    }

}
