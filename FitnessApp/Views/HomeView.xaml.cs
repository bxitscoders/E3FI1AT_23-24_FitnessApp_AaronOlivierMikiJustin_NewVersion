using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;


namespace FitnessApp.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                // Use the parent window reference to drag move
                if (Window.GetWindow(this) is Window window)
                {
                    window.DragMove();
                }
            }
        }

        private void CartesianChart_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

