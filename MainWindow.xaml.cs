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

namespace Adivina
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r;
        int numero;

        public MainWindow()
        {
            InitializeComponent();
            r = new Random();
            numero = r.Next(0, 6);
        }



        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {

            if (IntroducirTexBox.Text == numero.ToString())
                TextoTextBlock.Text = "Has acertado";
            if (int.Parse(IntroducirTexBox.Text) > numero)
                TextoTextBlock.Text = "Te has pasado";
            if (int.Parse(IntroducirTexBox.Text) < numero)
                TextoTextBlock.Text = "Te has quedado corto";


        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            numero = r.Next(0, 6);
            IntroducirTexBox.Clear();
            TextoTextBlock.Text = "";


        }
    }
}
