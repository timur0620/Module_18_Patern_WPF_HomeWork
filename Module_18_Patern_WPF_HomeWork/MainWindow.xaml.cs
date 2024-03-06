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
            presenter.Update();
        }

        private void btnCreate(object sender, RoutedEventArgs e)
        {
            presenter.Create();
        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            presenter.Delete();
        }

        private void btnAll(object sender, RoutedEventArgs e)
        {
            dataGridAnimals.ItemsSource =  presenter.GetAllAnimals();
        }
        private void btnMammals(object sender, RoutedEventArgs e)
        {
            dataGridAnimals.ItemsSource = presenter.GetAllMammals();
        }

        private void btnBirds(object sender, RoutedEventArgs e)
        {
            dataGridAnimals.ItemsSource = presenter.GetAllAmphibians();
        }

        private void btnAmphibians(object sender, RoutedEventArgs e)
        {
            dataGridAnimals.ItemsSource = presenter.GetAllAmphibians();
        }
        public int id { get => int.Parse(this.txtId.Text); set => int.Parse(this.txtId.Text); }
        public string Type { get => this.txtType.Text; set  => this.txtType.Text = value;}
        public int Count {  get => int.Parse(this.txtCount.Text);}
        public string Description { get => this.txtDescription.Text; set=> this.txtDescription.Text = value;}
        public List<IAnimals> animals { get => this.animals; set => this.animals = value;}

    }
}
