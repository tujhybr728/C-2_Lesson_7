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

namespace Lesson_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Value Stive = new Value();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_newepl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_newdep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_reastar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void textblokinfo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save_boutom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Load_boutom_Click(object sender, RoutedEventArgs e)
        {
            Stive.RewewAll();
            textblokinfo.AppendText(Stive.Listall[Stive.Listall.LongLength,1]);
        }
    }
}
