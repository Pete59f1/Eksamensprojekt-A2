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
        private MainWindow mainWindow;
        private int CheckedIndex { get; set; }
        private RadioButton CheckedRadioButton { get; set; }
        
        private PictureRepo newPictures;
        public NewPictures(MainWindow mainWindow)
        {
            
            this.mainWindow = mainWindow;
            InitializeComponent();
            UpdatePictures();
        }
        private void UpdatePictures()
        {
            newPictures = mainWindow.controller.GetPicturesWithNoCommentAndStatus();
            //foreach (GruppeA2.Domain.Picture picture in mainWindow.controller.activeBatch.CurrentDay.PictureRepo)
            //{


            //    RadioButton radioBtn = new RadioButton
            //    {
            //        Margin = new Thickness(2, 10, 2, 10),
            //        Height = 100,
            //        HorizontalAlignment = HorizontalAlignment.Center,
            //        VerticalAlignment = VerticalAlignment.Top,
            //        Content = new Image { Source = new BitmapImage(new Uri(picture.PictureLink, UriKind.Relative)) },
            //        Name = "_" + picture.PictureNumber.ToString()
            //    };
            //    radioBtn.Checked += this.Radio_Checked;
            //    WP_mainWrapPanel.Children.Add(radioBtn);


            //}

            for(int i = 0; i < newPictures.Count; i++)
            {


                RadioButton radioBtn = new RadioButton
                {
                    Margin = new Thickness(2, 10, 2, 10),
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = new Image { Source = new BitmapImage(new Uri(newPictures.GetPictureLink(newPictures.GetItem(i)), UriKind.Relative)) },
                    Name = "_" + newPictures.GetPictureNumber(newPictures.GetItem(i))
                };
                radioBtn.Checked += this.Radio_Checked;
                WP_mainWrapPanel.Children.Add(radioBtn);
            }
        }
        private void Radio_Checked(object sender, EventArgs e)
        {
            CheckedRadioButton = sender as RadioButton;
            CheckedIndex = Convert.ToInt32(CheckedRadioButton.Name.Substring(1));
            tb_Comment.Text = newPictures.GetPictureComment(CheckedIndex);
            cb_Growth.SelectedIndex = newPictures.GetPictureStatus(CheckedIndex);
        }


        private void NewPictures_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
           
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Btn_ViewPicture_Click(object sender, RoutedEventArgs e)
        {
            ViewPicture viewPicture = new ViewPicture(this, CheckedRadioButton.Content);
            this.Visibility = Visibility.Hidden;
            viewPicture.Show();
            
        }

        private void Cb_Growth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //if (mainWindow.controller.activeBatch.CurrentDay.PictureRepo[CheckedIndex] != null)
            //{
            string comment = tb_Comment.Text;
            string status = cb_Growth.SelectedValue.ToString();
            int pictureId = CheckedIndex;
            mainWindow.controller.save_picture(comment, status, pictureId);
            WP_mainWrapPanel.Children.Clear();
            UpdatePictures();
                //mainWindow.controller.activeBatch.CurrentDay.PictureRepo[CheckedIndex].ChangePictureComment(tb_Comment.Text);
                //mainWindow.controller.activeBatch.CurrentDay.PictureRepo[CheckedIndex].ChangePictureStatus(cb_Growth.SelectedIndex);
            //}
        }

        private void DeltePictre_Click(object sender, RoutedEventArgs e)
        {
            int pictureId = CheckedIndex;
            mainWindow.controller.delete_picture(pictureId);
            WP_mainWrapPanel.Children.Clear();
            UpdatePictures();
            //WP_mainWrapPanel.Children.Remove(CheckedRadioButton);
            //mainWindow.controller.activeBatch.CurrentDay.DeletePicture(CheckedIndex);
        }
    }
}
