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

            if (janela.ShowDialog() == true)
            {
                //MessageBox.Show(janela.FigurasEscolhida);
                lbFiguras.Items.Add(janela.FigurasEscolhida);
                //atualiza canvas

                switch (janela.FigurasEscolhida)

                {
                    case "Retângulo":
                        Rectangle rect1 = new Rectangle(); // Unique variable name
                        rect1.Width = 100;
                        rect1.Height = 50;
                        rect1.Stroke = Brushes.Red;

                        canvasRepresentação.Children.Add(rect1);
                        break;

                    case "Quadrado":
                        Rectangle rect2 = new Rectangle(); // Unique variable name
                        rect2.Width = 100;
                        rect2.Height = 100; // Assuming a square has equal width and height
                        rect2.Stroke = Brushes.Yellow;

                        canvasRepresentação.Children.Add(rect2);
                        break;
                }


            }
        }
        private void FigurasSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}