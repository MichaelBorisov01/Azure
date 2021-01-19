using FactorialCalculating;
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

namespace WpfAppFactorial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxNumber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = Int32.Parse(TextBoxNumber.Text);
            TextBoxResult.Text = "";
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            result = Factorial.Fact(a);
            TextBoxResult.Text = result.ToString();
        }
    }
}
