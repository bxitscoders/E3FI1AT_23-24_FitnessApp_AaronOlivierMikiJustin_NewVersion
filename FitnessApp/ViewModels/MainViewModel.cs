using FitnessApp.Views;
using System.Windows.Input;
using System.Windows;
using FitnessApp.Core;
using System;

namespace FitnessApp.ViewModels
{
    internal class MainViewModel
    {
        public ICommand ChartLoadedCommand { get; private set; }

        public ICommand SwitchToTrainingMenuCommand { get; private set; }

        public MainViewModel()
        {
            SwitchToTrainingMenuCommand = new RelayCommand(SwitchToTrainingMenuView);
            ChartLoadedCommand = new RelayCommand(ChartLoadedExecute);
        }

        private void SwitchToTrainingMenuView(object obj)
        {
            // Create an instance of the TrainingMenuView
            TrainingMenuView trainingMenuView = new TrainingMenuView();

            // Set the MainWindow's content to the TrainingMenuView instance
            Application.Current.MainWindow.Content = trainingMenuView;
        }

        private void ChartLoadedExecute(object parameter)
        {
            // Logic for the Chart in HomeView
        }

    }
}
