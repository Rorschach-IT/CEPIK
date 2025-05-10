using CepikAppWinUI.UserControlls;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CepikAppWinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowVehicles(object sender, RoutedEventArgs e)
        {
            // Set the ContentControl's content to your custom UserControl
            VehiclesView.Visibility = Visibility.Visible;
        }
    }
}
