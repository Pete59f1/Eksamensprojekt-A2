﻿using System;
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
        public NewPictures(MainWindow mainWindow)
        {
            
            this.mainWindow = mainWindow;
            InitializeComponent();
            UpdatePictures(mainWindow.controller.pictureRepo);
        }
        public void UpdatePictures(PictureRepo pictureRepo)
        {
            foreach (var picture in pictureRepo.RepoCollection)
            {
                
                
                
                WP_mainWrapPanel.Children.Add(new Button
                {
                    Margin = new Thickness(2, 10, 2, 10),
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = new Image { Source = new BitmapImage(new Uri(picture.PictureLink, UriKind.Relative)) }
                   
                    
                });
                
                
            }
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
            this.Visibility = Visibility.Hidden;
            
        }
    }
}
