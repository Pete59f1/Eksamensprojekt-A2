﻿using GruppeA2.Application;
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
        private PlantTypeRepo plants;
        private Controller con;
        private MainWindow mainWindow;
        public StartBatch(MainWindow mainWindow)
        {
            con = new Controller();
            this.mainWindow = mainWindow;
            InitializeComponent();
            plants = con.GetAllPlantType();
            for (int i = 0;i < plants.Count; i++)
            {
                cb_PlantType.Items.Add(plants.get_plant_type(plants.GetItem(i)));
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Cb_PlantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cb_Phase.Items.Clear();
            string chosen_type = cb_PlantType.SelectedItem.ToString();

            for (int i = 0; i < plants.Count; i++)
            {
                if(chosen_type == plants.get_plant_type(plants.GetItem(i))){
                    cb_Phase.Items.Add("Fase 1: " + plants.get_plant_phaseOne(plants.GetItem(i))+ " dage");
                    cb_Phase.Items.Add("Fase 2: " + plants.get_plant_phaseTwo(plants.GetItem(i)) + " dage");
                    cb_Phase.Items.Add("Fase 3: " + plants.get_plant_phaseThree(plants.GetItem(i)) + " dage");
                    cb_Phase.Items.Add("Fase 4: " + plants.get_plant_phaseFour(plants.GetItem(i)) + " dage");
                }
            }
        }
    }
}
