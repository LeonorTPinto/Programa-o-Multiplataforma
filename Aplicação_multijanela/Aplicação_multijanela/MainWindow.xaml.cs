using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aplicação_multijanela
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void FigurasAdiconar_Click(object sender, RoutedEventArgs e)
        {
                    Janela_Figuras janela = new Janela_Figuras();
            
                    if(janela.ShowDialog()==true) {
                //MessageBox.Show(janela.FigurasEscolhida);
               lbFiguras.Items.Add(janela.FigurasEscolhida);
                //atualiza canvas

                Rectangle rect =new Rectangle();
                rect.Width = 100;
                rect.Height = 50;
                rect.

                canvas.Representação.Children.Add(rect);
            }
        }

        private void FigurasSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}