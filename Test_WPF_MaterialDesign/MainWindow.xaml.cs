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

namespace Test_WPF_MaterialDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DG.ItemsSource = new List<Persona>() { new Persona(20,"Arthur"), new Persona(19,"Javier")};
        }
    }

    struct Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public Persona(int e, string n)
        {
            Edad = e;
            Nombre = n;
        }
    }
}
