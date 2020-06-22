using gPratical.View;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
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

namespace gPratical
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuHome = new List<SubItem>();
            menuHome.Add(new SubItem(""));
            menuHome.Add(new SubItem(""));
            var item1 = new ItemMenu("Home", menuHome, PackIconKind.Schedule);

            var menuCadastro = new List<SubItem>();
            menuCadastro.Add(new SubItem("Equipamentos", new CadastroEquipamentoUC()));
            menuCadastro.Add(new SubItem("Usuarios", new CadastroUsuarioUC()));
            menuCadastro.Add(new SubItem("Lembretes"));
            var item2 = new ItemMenu("Cadastro", menuCadastro, PackIconKind.Register);



            var menuEstoque = new List<SubItem>();
            menuEstoque.Add(new SubItem("Titulo1"));
            menuEstoque.Add(new SubItem("Titulo2"));
            var item3 = new ItemMenu("Estoque", menuEstoque, PackIconKind.ShoppingBasket);

            var menuPrinters = new List<SubItem>();
            menuPrinters.Add(new SubItem("Log"));
            menuPrinters.Add(new SubItem("Toners"));
            var item4 = new ItemMenu("Impressoras", menuPrinters, PackIconKind.FileReport);

            Menu.Children.Add(new MenuItemUC(item1, this));
            Menu.Children.Add(new MenuItemUC(item2, this));
            Menu.Children.Add(new MenuItemUC(item3, this));
            Menu.Children.Add(new MenuItemUC(item4, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                GridPanelMain.Children.Clear();
                GridPanelMain.Children.Add(screen);
            }
        }
    }
}