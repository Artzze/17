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

namespace эээ
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

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создатель: Журавлев" + Environment.NewLine + "7 вариант" + Environment.NewLine + "1.  Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P" + Environment.NewLine + "2. Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления, найти цифру, соответствующую разряду сотен в записи этого числа", "О программе");
        } // для переноса на след строку можно прописать "\n"

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RaschetClick(object sender, RoutedEventArgs e)
        {
            if (VvodA.Text != "" && VvodB.Text != "")
            {
                double a, b, c, P;
                bool f1 = double.TryParse(VvodA.Text, out a);
                bool f2 = double.TryParse(VvodB.Text, out b);
                if (f1 && f2)
                {
                    if (a == 0 || b == 0)
                    {
                        MessageBox.Show("a или b не может быть равен 0", "Ошибка");
                    }
                    else
                    {
                        c = Math.Sqrt(a * a + b * b);
                        P = c + a + b;
                        VivodC.Text = c.ToString("0.00");
                        VivodP.Text = P.ToString("0.00");
                    }
                }
                else
                { 
                        MessageBox.Show("a и b должны быть цифрой или числом", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Окна ввода не могут быть пустыми", "Ошибка");
            }
        }

        private void TextReset1(object sender, RoutedEventArgs e)
        {
            VivodC.Clear();
            VivodP.Clear();
        }

        private void TextReset2(object sender, RoutedEventArgs e)
        {
            VivodRazrada.Clear();
        }

        private void RazradClick(object sender, RoutedEventArgs e)
        {
            int chislo;
            bool f = int.TryParse(VvodChisla.Text, out chislo);
            if (VvodChisla.Text == "")
            {
                MessageBox.Show("Окно ввода не может быть пустым", "Ошибка");
            }
            else
            {
                if (f)
                {
                    if (chislo > 999)
                    {
                        VivodRazrada.Text = Convert.ToString(chislo / 100 % 10);
                    }
                    else
                    {
                        MessageBox.Show("Число должно быть больше 999", "Ошибка");
                    }
                }
                else
                    MessageBox.Show("Необходимо вводить число", "Ошибка");
            }
        }
    }
}