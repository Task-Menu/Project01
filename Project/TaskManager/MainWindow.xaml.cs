using System.Windows;

namespace TaskManager
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new StackWindow();
            window.Owner = this;
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new Grid();
            window.Owner = this;
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var window = new DataGrid();
            window.Owner = this;
            window.Show();
        }
    }
}
