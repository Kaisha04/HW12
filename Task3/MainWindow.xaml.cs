using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public event EventHandler Start = null;
        public event EventHandler Stop = null;
        public event EventHandler Reset = null;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public void UpdateTime(string timeText)
        {
            TimerText.Text = timeText;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start?.Invoke(this, EventArgs.Empty);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Stop?.Invoke(this, EventArgs.Empty);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reset?.Invoke(this, EventArgs.Empty);
        }
    }
}