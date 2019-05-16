using GruppeA2.Application;
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
    /// Interaction logic for StartBatch.xaml
    /// </summary>
    public partial class StartBatch : Window
    {
        private Controller con;
        private MainWindow mainWindow;
        public StartBatch(MainWindow mainWindow)
        {
            con = new Controller();
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Btn_Test_Click(object sender, RoutedEventArgs e)
        {
            PlantTypeRepo pl = con.GetAllPlantType();

        }
    }
}
