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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void computeButton_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(numberTextBox.Text);

            var sb = new StringBuilder();

            // 根據 n 與 n*n 的位數，對齊被乘數與乘積（配合等寬字型顯示）
            int operandWidth = n.ToString().Length;
            int productWidth = (n * n).ToString().Length;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    string left = i.ToString().PadLeft(operandWidth) + "*" + j.ToString().PadLeft(operandWidth) + "=";
                    string prod = (i * j).ToString().PadLeft(productWidth);
                    sb.Append(left + prod + " ");
                }
                sb.AppendLine();
            }


            resultTextBlock.Text = sb.ToString();
        }
    }
}
