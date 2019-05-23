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
        private BatchRepo batchRepo;

        public FindPicture(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            batchRepo = mainWindow.controller.GetAllBatches();
            LoadBatch();
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
        private void LoadBatch()
        {
            for (int i = 0; i < batchRepo.Count; i++)
            {
                cbb_BatchNumber.Items.Add(batchRepo.GetProductionNumberByIndex(i));
            }
        }

        private void Btn_ViewPictures_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            int batchNr = int.Parse(cbb_BatchNumber.SelectedItem.ToString());
            int dayNr = int.Parse(cbb_DayNumber.SelectedItem.ToString());
            BatchRepo chosen = GetChosenBatch(batchNr, dayNr);
            chosen.AddPictureDataFromDayId(batchNr, dayNr);
            NewPictures newPictures = new NewPictures(this, chosen);
            newPictures.Show();
        }

        private void Cbb_BatchNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbb_DayNumber.Items.Clear();
            cbb_DayNumber.SelectedIndex = -1;
            int chosenBatchNr = int.Parse(cbb_BatchNumber.SelectedItem.ToString());
            List<int> days = batchRepo.GetDayNrByBatchId(chosenBatchNr);
            foreach (int day in days)
            {
                cbb_DayNumber.Items.Add(day);
            }
        }

        private BatchRepo GetChosenBatch(int batchNr, int dayNr)
        {
            BatchRepo chosen = new BatchRepo();
            for (int i = 0; i < batchRepo.Count; i++)
            {
                if (batchRepo.GetProductionNumberByIndex(i).Equals(batchNr))
                {
                    chosen.AddItem(batchRepo.GetItem(i));
                    chosen.DeleteAllDaysButChosen(batchNr, dayNr);
                }
            }
            return chosen;
        }
    }
}
