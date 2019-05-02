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

namespace GUI
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
        private void EndProduction_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            EndProcess endProcess = new EndProcess(this);
            endProcess.Show();
        }
        private void TerminateProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
