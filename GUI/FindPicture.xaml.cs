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
    /// Interaction logic for FindPicture.xaml
    /// </summary>
    public partial class FindPicture : Window
    {
        private MainWindow mainWindow;
        public FindPicture(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }
        private void FindPicture_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;

        }

        private void TrayNr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
