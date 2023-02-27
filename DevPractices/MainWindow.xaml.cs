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
using Patterns.Prototype.Interface;

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

        private void ButtonPrototype_Click(object sender, RoutedEventArgs e)
        {
            ShapeProt shapeProt1 = new ShapeProt(1);
            shapeProt1.Name = "ShapeProt1";
            shapeProt1.Color = "Red";
            ShapeProt shapeProt2 =   shapeProt1.Clone();
            shapeProt2.Id = 2;
            shapeProt2.Color = "Blue";
            ShapeProt shapeProt3 = shapeProt2.Clone();
            shapeProt3.Id = 3;
            shapeProt3.Name = "ShapeProt3";
            shapeProt3.Color = "Yellow";
            MessageBox.Show($"Shape 1: Id: {shapeProt1.Id} Name: {shapeProt1.Name} Color: {shapeProt1.Color} | " +
                $"Shape 2 Deep: Id: {shapeProt2.Id} Name: {shapeProt2.Name} Color: {shapeProt2.Color} | " +
                $"Shape 3 Clone: Id: {shapeProt3.Id} Name: {shapeProt3.Name} Color: {shapeProt3.Color}");


        }
    }
}
