using DevPractices.Implementation;
using DevPractices.Interfaces;
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
using Patterns.AbstractFactory.Implementations.Dotnet;
using Patterns.AbstractFactory.Interfaces;
using Patterns.AbstractFactory.Implementations.RoR;
using Patterns.Singleton.Implementations;

namespace DevPractices
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

        private void ButtonQS_Click(object sender, RoutedEventArgs e)
        {
            ISortData sortData = new SortData();
            //int[] arrayToSort = { 10, 80, 30, 90, 40, 50, 70 };
            int[] arrayToSort = { 4, 5, 6, 7, 8, 9, 8, 3, 2, 3, 4, 5, 6, 7, 8, 9, 8, 6, 5, 45, 4, 0, 9, 87654, 88, 3, 4, 78, 5, 6, 66, 7, 99, 8, 9, 0, 9, 8, 7, 33, 6, 4, 77, 5, 67 };
            sortData.QSSort(ref arrayToSort);
        }

        private void ButtonAbstract_Click(object sender, RoutedEventArgs e)
        {
            //DotnetFactory dotnetFactory = new DotnetFactory();
            //var front = dotnetFactory.CreateFrontEnd();
            //var back = dotnetFactory.CreateBackend();
            //var db = dotnetFactory.CreateDataBase();
            //MessageBox.Show($"Created factory: {dotnetFactory.ToString()}, front:{front.ToString()}, back: {back.ToString()}, db: {db.ToString()}");

            RoRFactory roRFactory = new RoRFactory();
            var front = roRFactory.CreateFrontEnd();
            var back = roRFactory.CreateBackend();
            var db = roRFactory.CreateDataBase();
            MessageBox.Show($"Created factory: {roRFactory.ToString()}, front:{front.ToString()}, back: {back.ToString()}, db: {db.ToString()}");
        }

        private void ButtonSingleton_Click(object sender, RoutedEventArgs e)
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton newSingleton = Singleton.GetInstance();
            if (singleton == newSingleton) {
                MessageBox.Show("Same Instance");
             }
            else
            {
                MessageBox.Show("Not Working");
            }

        }
    }
}
