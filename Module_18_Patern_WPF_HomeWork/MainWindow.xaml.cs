using Module_18_Patern_WPF_HomeWork.Model;
using Module_18_Patern_WPF_HomeWork.Model.SaveToFile.Context;
using Module_18_Patern_WPF_HomeWork.PresenterAnimals;
using Module_18_Pattern_Console_HomeWork.Model;
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
using Bogus;

namespace Module_18_Patern_WPF_HomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {  
        Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreate(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
   
        }

        private void btnAll(object sender, RoutedEventArgs e)
        {
            //presenter = new Presenter(this);
            //dataGridAnimals.ItemsSource = presenter.ResultGetAnimals();

            //ContextAnimals db  = new ContextAnimals();

        }

        private void btnMammals(object sender, RoutedEventArgs e)
        {

        }

        private void btnBirds(object sender, RoutedEventArgs e)
        {

        }

        private void btnAmphibians(object sender, RoutedEventArgs e)
        {

        }



        //public string id { get => this.txtId.Text; set => this.txtId.Text = value; }
        //public string Type { get => this.txtType.Text; set  => this.txtType.Text = value;}
        //public string Count { get => this.txtCount.Text; set => this.txtCount.Text = value; }
        //public string Name { get => this.txtName.Text; set => this.txtName.Text = value; }
        //public string Description { get => this.txtDescription.Text; set=> this.txtDescription.Text = value;}
        public List<IAnimals> animals { get => this.animals; set => this.animals = value; }

    }
}
