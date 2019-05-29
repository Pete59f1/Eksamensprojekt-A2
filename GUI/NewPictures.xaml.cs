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
    /// Interaction logic for NewPictures.xaml
    /// </summary>
    public partial class NewPictures : Window
    {
        private int batchNr;
        private int dayNr;
        private Controller controller;
        private Window previousWindow;
        private BatchRepo chosenBatch;
        private int CheckedIndex { get; set; }
        private RadioButton CheckedRadioButton { get; set; }
        
        public NewPictures(Window previousWindow)
        {
            this.previousWindow = previousWindow;
            controller=Controller.ControllerInstance;
            InitializeComponent();
            LoadNewPicturesRepo(controller.GetPicturesWithNoCommentAndStatus());
        }
        public NewPictures(Window previousWindow, BatchRepo chosenBatch, int batchNr, int dayNr)
        {
            this.previousWindow = previousWindow;
            this.chosenBatch = chosenBatch;
            this.batchNr = batchNr;
            this.dayNr = dayNr;
            controller = Controller.ControllerInstance;
            InitializeComponent();
            LoadDataFromFindPicture(chosenBatch);
        }

        private void LoadNewPicturesRepo(NewPicturesRepo pictureRepo)
        {
            for(int i = 0; i < pictureRepo.Count; i++)
            {
                RadioButton radioBtn = new RadioButton
                {
                    Margin = new Thickness(2, 10, 2, 10),
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = new Image { Source = new BitmapImage(new Uri(pictureRepo.GetPictureLinkByIndex(i), UriKind.Relative)) },
                    Name = "_" + pictureRepo.GetPictureIdByIndex(i)
                };
                radioBtn.Checked += this.Radio_Checked;
                WP_mainWrapPanel.Children.Add(radioBtn);
            }
        }

        private void LoadDataFromFindPicture(BatchRepo chosen)
        {
            
            for (int i = 0; i < chosen.Count; i++)
            {
                RadioButton radioBtn = new RadioButton
                {
                    Margin = new Thickness(2, 10, 2, 10),
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = new Image { Source = new BitmapImage(new Uri(chosen.GetPictureLinkByIndex(batchNr, dayNr, i), UriKind.Relative)) },
                    Name = "_" + chosen.GetPictureIdByIndex(batchNr, dayNr, i)
                };
                radioBtn.Checked += this.Radio_CheckedFindPicture;
                WP_mainWrapPanel.Children.Add(radioBtn);
            }
        }

        private void Radio_Checked(object sender, EventArgs e)
        {
            CheckedRadioButton = sender as RadioButton;
            CheckedIndex = Convert.ToInt32(CheckedRadioButton.Name.Substring(1));
        }

        private void Radio_CheckedFindPicture(object sender, EventArgs e)
        {
            CheckedRadioButton = sender as RadioButton;
            CheckedIndex = Convert.ToInt32(CheckedRadioButton.Name.Substring(1));
            tb_Comment.Text = chosenBatch.GetPictureCommentByIndex(batchNr, dayNr, CheckedIndex);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            previousWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Btn_ViewPicture_Click(object sender, RoutedEventArgs e)
        {
            ViewPicture viewPicture = new ViewPicture(this, CheckedRadioButton.Content, CheckedIndex);
            this.Visibility = Visibility.Hidden;
            viewPicture.Show();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string comment = tb_Comment.Text;
            string status = cb_Growth.Text;
            int pictureId = CheckedIndex;
            
            controller.save_picture(comment, status, pictureId);
            WP_mainWrapPanel.Children.Clear();
            LoadNewPicturesRepo(controller.GetPicturesWithNoCommentAndStatus());

            //WP_mainWrapPanel.Children.Clear();
            //LoadNewPicturesRepo(controller.GetPicturesWithNoCommentAndStatus()); Giver problemer når man gemmer fra findpicture
        }

        private void DeletePicture_Click(object sender, RoutedEventArgs e)
        {
            int pictureId = CheckedIndex;
            controller.delete_picture(pictureId);
            WP_mainWrapPanel.Children.Clear();
            LoadNewPicturesRepo(controller.GetPicturesWithNoCommentAndStatus());
        }

            //LoadNewPicturesRepo(controller.GetPicturesWithNoCommentAndStatus()); Giver problemer når man gemmer fra findpicture
        

    }
}
