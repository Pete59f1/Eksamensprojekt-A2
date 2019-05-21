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
        private MainWindow mainWindow;
        private int CheckedIndex { get; set; }
        private Window previousWindow;
        public Image ChoosenImage { get; set; }

        public ViewPicture(Window previousWindow, object choosenImage, int checkedIndex)
        {
            InitializeComponent();
            ChoosenImage = choosenImage as Image;
            this.previousWindow = previousWindow;
            im_PictureToBeShown.Source = ChoosenImage.Source;
            CheckedIndex = checkedIndex;
            mainWindow = 
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string comment = tb_comment.Text;
            string status = cb_Status.Text;
            int pictureId = CheckedIndex;
            mainWindow.controller.save_picture(comment, status, pictureId);
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            
            mainWindow.controller.delete_picture(CheckedIndex);
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        
    }
}
