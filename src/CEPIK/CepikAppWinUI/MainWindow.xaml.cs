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

            LoadView(new VehiclesView()); // Default start
        }

        private void LoadView(UIElement view)
        {
            MainContentArea.Children.Clear(); // Remove previous
            MainContentArea.Children.Add(view); // Add new

            Grid.SetRow((FrameworkElement)view, 0);
            Grid.SetColumn((FrameworkElement)view, 0);
            Grid.SetColumnSpan((FrameworkElement)view, 5);
        }

        private void ShowVehicles(object sender, RoutedEventArgs e) =>
            LoadView(new VehiclesView());

        private void ShowPeople(object sender, RoutedEventArgs e) =>
            LoadView(new PeopleView());

        private void ShowInsurances(object sender, RoutedEventArgs e) =>
            LoadView(new AssigningInsurancesToVehiclesView());

        private void ShowVehicleOwners(object sender, RoutedEventArgs e) =>
            LoadView(new AssigningOwnersToVehiclesView());

        private void ShowLicenceCategories(object sender, RoutedEventArgs e) =>
            LoadView(new CategoriesView());

        private void ShowOffences(object sender, RoutedEventArgs e) =>
            LoadView(new OffencesView());

        private void ShowPermissions(object sender, RoutedEventArgs e) =>
            LoadView(new AssigningOwnersToLicencesView());

        private void ShowVehiclesEvents(object sender, RoutedEventArgs e) =>
            LoadView(new VehiclesEventsView());
    }
}