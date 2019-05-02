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
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Archive.xaml
    /// </summary>
    public partial class Archive : Window
    {
        private MainWindow mainWindow;
        public Archive(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void ProdNr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PlantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
        private void Archive_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;

        }
    }
}
