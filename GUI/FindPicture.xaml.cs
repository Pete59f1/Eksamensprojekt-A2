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
    /// Interaction logic for FindPicture.xaml
    /// </summary>
    public partial class FindPicture : Window
    {
        private MainWindow mainWindow;
        private int CheckedIndex { get; set; }
        private RadioButton CheckedRadioButton { get; set; }
        private NewPicturesRepo pictureRepo;
        private BatchRepo batchRepo;
        public FindPicture(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            batchRepo = mainWindow.controller.GetAllBatches();
        }
        private void UpdatePictures(NewPicturesRepo pictureRepo)
        {


            for (int i = 0; i < pictureRepo.Count; i++)
            {


                RadioButton radioBtn = new RadioButton
                {
                    Margin = new Thickness(2, 10, 2, 10),
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = new Image { Source = new BitmapImage(new Uri(pictureRepo.GetPictureLink(pictureRepo.GetItem(i)), UriKind.Relative)) },
                    Name = "_" + pictureRepo.GetPictureNumber(pictureRepo.GetItem(i))
                };
                radioBtn.Checked += this.Radio_Checked;
                WP_mainWrapPanel.Children.Add(radioBtn);
            }
        }
        private void Radio_Checked(object sender, EventArgs e)
        {

            CheckedRadioButton = sender as RadioButton;
            CheckedIndex = Convert.ToInt32(CheckedRadioButton.Name.Substring(1));
        }
        private void FindPicture_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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
            this.Visibility = Visibility.Hidden;
            ViewPicture viewPicture = new ViewPicture(this, new object(), 1);
            viewPicture.Show();
        }

        private void DayNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BatchNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
