using FitnessApp.Views;
using System.Windows.Input;
using System.Windows;
using FitnessApp.Core;
using System;

namespace FitnessApp.ViewModels
{
    internal class MainViewModel
    {
        public ICommand SwitchToTrainingMenuCommand { get; private set; }

        public MainViewModel()
        {
            SwitchToTrainingMenuCommand = new RelayCommand(SwitchToTrainingMenuView);
        }

        private void SwitchToTrainingMenuView(object obj)
        {
            // Create an instance of the TrainingMenuView
            TrainingMenuView trainingMenuView = new TrainingMenuView();

            // Set the MainWindow's content to the TrainingMenuView instance
            Application.Current.MainWindow.Content = trainingMenuView;
        }

        




        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
