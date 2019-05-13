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
    /// Interaction logic for Archive.xaml
    /// </summary>
    public partial class Archive : Window
    {
        private MainWindow mainWindow;
        private int CheckedIndex { get; set; }
        private RadioButton CheckedRadioButton { get; set; }
        private List<RadioButton> RadioButtons  { get; set; }
        public Archive(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            UpdatePictures(mainWindow.controller.notActivePictureRepo);
        }
        public void UpdatePictures(PictureRepo notActivePictureRepo)
        {
            foreach (var picture in notActivePictureRepo.RepoCollection)
            {


                RadioButton radioBtn = new RadioButton
                {
                    Margin = new Thickness(2, 10, 2, 10),
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = new Image { Source = new BitmapImage(new Uri(picture.PictureLink, UriKind.Relative)) },
                    Name = "_" + picture.PictureNumber.ToString(),



                };
                radioBtn.Checked += this.Radio_Checked;
                WP_mainWrapPanel.Children.Add(radioBtn);
                RadioButtons.Add(radioBtn);


            }
        }

        private void UpdateProductionNumbersInCb(PictureRepo notActivePictureRepo)
        {
            foreach (var item in notActivePictureRepo.RepoCollection)
            {
                
            }
        }
        private void Radio_Checked(object sender, EventArgs e)
        {
            CheckedRadioButton = sender as RadioButton;
            CheckedIndex = Convert.ToInt32(CheckedRadioButton.Name.Substring(1));
            
        }
        private void ProdNr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PlantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
        private void Archive_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;

        }

        private void Btn_ViewPicture_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
           
           
        }
    }
}
