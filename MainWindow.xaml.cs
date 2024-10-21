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

namespace Треугольник
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try


            {
                long s1 = Int64.Parse(_1сторона.Text);
                long s2 = Int64.Parse(_2сторона.Text);
                long s3 = Int64.Parse(_3сторона.Text);
                string text1 = _1сторона.Text;
                string text2 = _2сторона.Text;
                string text3 = _3сторона.Text;
                if (s1 + s2 <= s3 || s2 + s3 <= s1 || s1 + s3 <= s2)
                    MessageBox.Show("Этого треугольника не существует");
                else
                {
                    if (s1 == s2 && s2 == s3 && s1 == s3)
                        MessageBox.Show("Этот треугольник равносторонний");
                    else
                    {
                        if (s1 == s2 || s2 == s3 || s1 == s3)
                            MessageBox.Show("Этот треугольник равнобедренный");
                        else
                        {
                            if (s1 != s2 && s2 != s3 && s1 != s3)
                                MessageBox.Show("Этот треугольник разносторонний");
                            else
                            {
                                if (text1 == String.Empty || text2 == String.Empty || text3 == String.Empty)
                                    MessageBox.Show("Введите данные");
                            }
                        }
                    }
                }
            }
            catch

            {
                MessageBox.Show("Вы ввели не верные данные пожаллуйста повторите ввод");
            }
            _1сторона.Text = "";
            _2сторона.Text = "";
            _3сторона.Text = "";
        }
    }
}
