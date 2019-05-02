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
    /// Interaction logic for EndProcess.xaml
    /// </summary>
    public partial class EndProcess : Window
    {
        private MainWindow mainWindow;
        public EndProcess(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Btn_RemoveTray_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_EndProduction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
