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
using Task4;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler AdditionEvent = null;
        public event EventHandler SubstractionEvent;
        public event EventHandler MultiplicationEvent;
        public event EventHandler DivisionEvent;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            AdditionEvent?.Invoke(this, e);
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            SubstractionEvent?.Invoke(this, e);
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            MultiplicationEvent?.Invoke(this, e);
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            DivisionEvent?.Invoke(this, e);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public double GetFirstNumber()
        {
            return Convert.ToDouble(textbox.Text);
        }

        public double GetSecondNumber()
        {
            return Convert.ToDouble(textbox.Text);
        }
        public void SetResult(double result)
        {
            textbox.Text = result.ToString();
        }
    }
}