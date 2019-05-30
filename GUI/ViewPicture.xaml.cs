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
using GruppeA2.Application;
namespace GUI
{
    /// <summary>
    /// Interaction logic for ViewPicture.xaml
    /// </summary>
    public partial class ViewPicture : Window
    {
        private Controller con;
        private int CheckedIndex { get; set; }
        private Window previousWindow;
        public Image ChoosenImage { get; set; }

        public ViewPicture(Window previousWindow, object choosenImage, int checkedIndex)
        {
            con = Controller.ControllerInstance;
            InitializeComponent();
            ChoosenImage = choosenImage as Image;
            this.previousWindow = previousWindow;
            im_PictureToBeShown.Source = ChoosenImage.Source;
            CheckedIndex = checkedIndex;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string comment = tb_Comment.Text;
            string status = cb_Status.Text;
            int pictureId = CheckedIndex;
            con.SavePicture(comment, status, pictureId);
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            
            con.DeletePicture(CheckedIndex);
            previousWindow.Visibility = Visibility.Visible;
            this.Close();

        }
    }
}
