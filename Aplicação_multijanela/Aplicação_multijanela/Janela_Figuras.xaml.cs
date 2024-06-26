﻿using System;
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
using System.Windows.Shapes;

namespace Aplicação_multijanela
{
    /// <summary>
    /// Lógica interna para Janela_Figuras.xaml
    /// </summary>
    public partial class Janela_Figuras : Window
    {   
        public string FigurasEscolhida {  get; private set; }
        public Janela_Figuras()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            if (cbFiguras.SelectedIndex >= 0)
            {
                switch(cbFiguras.SelectedIndex)
                {
                    case 0: FigurasEscolhida = "Quadrado";
                        break;
                    case 1:
                        FigurasEscolhida = "Retangulo";
                        break;
                    case 2:
                        FigurasEscolhida = "Circulo";
                        break;
                }
               // FigurasEscolhida = cbFiguras.SelectedValue.ToString();
                this.DialogResult = true;
            }
        }
    }
}
