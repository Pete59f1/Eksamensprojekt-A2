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
    /// Interaction logic for ViewPicture.xaml
    /// </summary>
    public partial class ViewPicture : Window
    {
        private Window previousWindow;
        public ViewPicture(Window previousWindow, Image choosenImage)
        {
            this.previousWindow = previousWindow;
            im_PictureToBeShown.Source = choosenImage.Source;
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
