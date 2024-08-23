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

namespace WpfDaisyDuck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Duck Instance variables
        Duck daisy = null;
        Duck huey = null;
        Duck duey = null;
        Duck louie = null;
        Duck donald = null;

        public MainWindow()
        {
            InitializeComponent();

            //instantiate Duck variables
            daisy = new Duck("Daisy");
            huey = new Duck("Huey");
            duey = new Duck("Duey");
            louie = new Duck("Louie");
            donald = new Duck("Donald");

            daisy.speakDel += huey.Listening;
            daisy.speakDel += duey.Listening;
            daisy.speakDel += louie.Listening;

            daisy.speakDel += donald.StandUp;

            //Add Lambda eventhandler to daisy button, programmatically
            btnDaisy.Click -= btnDaisy_Click;
            btnDaisy.Click += (s,e) => daisy.Speak();

        }

        private void btnDaisy_Click(object sender, RoutedEventArgs e)
        {
            //Make Daisy ask
            daisy.Speak();

        }
    }
}
