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
            rojoRadioButton.IsChecked = true;
        }

        private void MainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoFinalTextBlock.Text = mainTextBox.Text;
        }
        private void NegritaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontWeight = negritaCheckBox.IsChecked == true ? FontWeights.Bold : FontWeights.Normal;
        }
        private void CursivaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontStyle = cursivaCheckBox.IsChecked == true ? FontStyles.Italic : FontStyles.Normal;
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
