using gPratical.Classes;
using gPratical.Classes.Proprerties;
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
    /// Interação lógica para CadastroEquipamentoUC.xam
    /// </summary>
    public partial class CadastroEquipamentoUC : UserControl
    {
        public CadastroEquipamentoUC()
        {
            InitializeComponent();
            CarregarCmbItens();
        }


        private void CarregarCmbItens()
        {
            CarregarCmbTipo();
            CarregarCmbVoltagemEntrada();
            CarregarCmbVoltagemSaida();
            CarregarCmbSetor();
        }

        private void CarregarCmbSetor()
        {
            var setor = Setor.GetSetores();

            cmbSetor.ItemsSource = setor;
            cmbSetor.DisplayMemberPath = "Nome";
            cmbSetor.SelectedValuePath = "Nome";
        }

        private void CarregarCmbVoltagemSaida()
        {
            var voltagens = Voltagem.GetVoltagensSaida();

            cmbVoltagemSaida.ItemsSource = voltagens;
            cmbVoltagemSaida.DisplayMemberPath = "Nome";
            cmbVoltagemSaida.SelectedValuePath = "Nome";
        }

        private void CarregarCmbVoltagemEntrada()
        {
            var voltagens = Voltagem.GetVoltagensEntrada();

            cmbVoltagemEntrada.ItemsSource = voltagens;
            cmbVoltagemEntrada.DisplayMemberPath = "Nome";
            cmbVoltagemEntrada.SelectedValuePath = "Nome";
        }

        private void CarregarCmbTipo()
        {
            var tipos = Tipo.GetTipos();

            cmbTipo.ItemsSource = tipos;
            cmbTipo.DisplayMemberPath = "Nome";
            cmbTipo.SelectedValuePath = "Nome";
        }

        Equipamentos.Unit LeituraFormulario()
        {

            Equipamentos.Unit E = new Equipamentos.Unit();

            E.Tipo = cmbTipo.SelectedValue.ToString();
            E.Marca = txtMarca.Text;
            E.Modelo = txtModelo.Text;
            E.SerialNumber = txtSN.Text;
            E.VoltagemEntrada = cmbVoltagemEntrada.SelectedValue.ToString();
            E.VoltagemSaida = cmbVoltagemSaida.SelectedValue.ToString();
            E.Potencia = txtPotencia.Text;
            E.Validade = Convert.ToDateTime(dtpValidade.SelectedDate);
            E.Setor = cmbSetor.SelectedValue.ToString();
            E.Local = txtLocal.Text;

            return E;
        }


        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Equipamentos.Unit E = new Equipamentos.Unit();
                E = LeituraFormulario();
                E.ValidaClasse();
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

        private void cmbSetor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtLocal.Visibility = Visibility.Visible;
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimpaFormulario();
        }

        private void LimpaFormulario()
        {

            cmbTipo.SelectedValue = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtSN.Text = "";
            cmbVoltagemEntrada.SelectedValue = "";
            cmbVoltagemSaida.SelectedValue = "";
            txtPotencia.Text = "";
            dtpValidade.SelectedDate.GetValueOrDefault();
            cmbSetor.SelectedValue = "";
            txtLocal.Text = "";
            txtLocal.Visibility = Visibility.Collapsed;
        }
    }
}
