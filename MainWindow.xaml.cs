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

namespace WpfApp1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ok_button_Click(object sender, RoutedEventArgs e)
        {
            string name = nametextbox.Text;
            string telphone = telNameTextBox.Text;
            string message = $"Name: {name}\nTelphone: {telphone}";
            MessageBox.Show(message, "我的資訊", MessageBoxButton.OK);
        }
    }
}