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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoFinalTextBlock.Text = mainTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontWeight = FontWeights.Bold;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontStyle = FontStyles.Italic;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.Foreground = Brushes.Green;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.Foreground = Brushes.Blue;
        }
    }
}
