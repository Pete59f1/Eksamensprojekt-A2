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
    /// Interaction logic for NewPictures.xaml
    /// </summary>
    public partial class NewPictures : Window
    {
        private MainWindow mainWindow;
        public NewPictures(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            
        }

        private void NewPictures_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
           
        }

    }
}
