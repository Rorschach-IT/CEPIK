using CepikAppWinUI.UserControlls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

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
            MainContentArea.Children.Clear(); // Wyczyœæ poprzedni¹ zawartoœæ
            var vehiclesView = new VehiclesView(); // Stwórz now¹ instancjê
            MainContentArea.Children.Add(vehiclesView); // Dodaj j¹ do siatki

            // Dostosuj rozci¹ganie
            Grid.SetRow(vehiclesView, 0);
            Grid.SetColumn(vehiclesView, 0);
            Grid.SetColumnSpan(vehiclesView, 5);
        }
    }
}
