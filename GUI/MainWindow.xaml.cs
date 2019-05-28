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
using GruppeA2.Application;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Controller controller;
        public MainWindow()
        {
            controller = Controller.ControllerInstance;
            DataContext = controller;
            InitializeComponent();
        }

        private void NewPictures_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            NewPictures newPictures = new NewPictures(this);
            newPictures.Show(); 
        }
        private void FindPictures_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            FindPicture findPicture = new FindPicture(this);
            findPicture.Show();
        }
        private void PictureArchive_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Archive archive = new Archive(this);
            archive.Show();
        }

        private void TerminateProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartBarch_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            StartBatch startBatch = new StartBatch(this);
            startBatch.Show();
        }
    }
}
