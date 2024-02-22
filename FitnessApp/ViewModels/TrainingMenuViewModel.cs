using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows;
using FitnessApp.Core;
using System.Windows.Input;
using System.Windows.Controls;
using FitnessApp.Views;
using System.Windows.Navigation;

namespace FitnessApp.ViewModels
{
    internal class TrainingMenuViewModel
    {
        public ICommand BackToHomeCommand { get; }
        public ICommand StartTrainingCommand { get; }
        public ICommand ConfigureNewTrainingCommand { get; }

        public TrainingMenuViewModel()
        {
            BackToHomeCommand = new RelayCommand(BackToHome);
            StartTrainingCommand = new RelayCommand(StartTraining);
            ConfigureNewTrainingCommand = new RelayCommand(ConfigureNewTraining);
        }

        private void BackToHome(object parameter)
        {
            // Assuming you have a reference to the ContentControl where you want to display the HomeView
            if (Application.Current.MainWindow.Content is ContentControl contentControl)
            {
                // Assuming HomeView is instantiated and its DataContext (ViewModel) is properly set
                HomeView homeView = new HomeView();
                contentControl.Content = homeView;
            }
        }

        private void StartTraining(object parameter)
        {
            // Your logic for starting training
            // You can access StartTrainingButton.Background here
        }

        private void ConfigureNewTraining(object parameter)
        {
            // Your logic for configuring new training
            // You can access BacktoHomeButton.Background here
        }
    }
}

