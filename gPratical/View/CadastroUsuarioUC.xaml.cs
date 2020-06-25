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
                MessageBox.Show("Classe foi inicializada sem erros", "gPratical", MessageBoxButton.OK, MessageBoxImage.Information); ;
                LimpaFormulario();
            }

            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "gPratical", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (Exception)
            {
                MessageBox.Show("Cadastro não inicializado com sucesso, preencha todos os campos", "gPratical", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
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
            C.Genero = cmbGenero.SelectedValue.ToString();

            return C;
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimpaFormulario();
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LimpaFormulario()
        {
            txtBairro.Text = null;
            txtCargo.Text = null;
            txtCidade.Text = null;
            txtEndereco.Text = null;
            txtNome.Text = null;
            txtTelefone.Text = null;
            cmbEstado.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbSetor.SelectedIndex = -1;
            dtpDataNascimento.SelectedDate = null;
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
