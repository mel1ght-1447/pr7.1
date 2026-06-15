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

namespace pr7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Я первая в очереди.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Random rnd = new Random();
            switch (rnd.Next(0,5))
            {
                case 0:
                    MessageBox.Show("Клеопатра жила за 2000 лет до изобретения помады, но использовала сок ягод и толчёных муравьёв.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 1:
                    MessageBox.Show("Мона Лиза была признана эталоном красоты эпохи Возрождения.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    MessageBox.Show("Одри Хепберн считала себя «некрасивой» и стеснялась своего роста и носа, но стала иконой стиля.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 3:
                    MessageBox.Show("Танцовщицы Фламенко в Испании специально подчёркивают мускулистые руки - это символ силы и женственности.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 4:
                    MessageBox.Show("Мэрлин Монро стеснялась своего лёгкого заикания и родинки над губой, но именно они стали её «изюминкой».", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }
    }
}
