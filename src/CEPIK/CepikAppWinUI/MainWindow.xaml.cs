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

            var vehiclesView = new VehiclesView();
            MainContentArea.Children.Add(vehiclesView);

            Grid.SetRow(vehiclesView, 0);
            Grid.SetColumn(vehiclesView, 0);
            Grid.SetColumnSpan(vehiclesView, 5);
        }

        private void ShowVehicles(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var vehiclesView = new VehiclesView();
            MainContentArea.Children.Add(vehiclesView);

            Grid.SetRow(vehiclesView, 0);
            Grid.SetColumn(vehiclesView, 0);
            Grid.SetColumnSpan(vehiclesView, 5);
        }

        private void ShowPeople(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var peopleView = new PeopleView();
            MainContentArea.Children.Add(peopleView);

            Grid.SetRow(peopleView, 0);
            Grid.SetColumn(peopleView, 0);
            Grid.SetColumnSpan(peopleView, 5);
        }

        private void ShowInsurances(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var insurancesView = new AssigningInsurancesToVehiclesView();
            MainContentArea.Children.Add(insurancesView);

            Grid.SetRow(insurancesView, 0);
            Grid.SetColumn(insurancesView, 0);
            Grid.SetColumnSpan(insurancesView, 5);
        }

        private void ShowVehicleOwners(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var vehicleOwnersView = new AssigningOwnersToVehiclesView();
            MainContentArea.Children.Add(vehicleOwnersView);

            Grid.SetRow(vehicleOwnersView, 0);
            Grid.SetColumn(vehicleOwnersView, 0);
            Grid.SetColumnSpan(vehicleOwnersView, 5);
        }

        private void ShowLicenceCategories(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var licenceCategoriesView = new CategoriesView();
            MainContentArea.Children.Add(licenceCategoriesView);

            Grid.SetRow(licenceCategoriesView, 0);
            Grid.SetColumn(licenceCategoriesView, 0);
            Grid.SetColumnSpan(licenceCategoriesView, 5);
        }

        private void ShowOffences(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var offencesView = new OffencesView();
            MainContentArea.Children.Add(offencesView);

            Grid.SetRow(offencesView, 0);
            Grid.SetColumn(offencesView, 0);
            Grid.SetColumnSpan(offencesView, 5);
        }

        private void ShowPermissions(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var permissionsView = new AssigningOwnersToLicencesView();
            MainContentArea.Children.Add(permissionsView);

            Grid.SetRow(permissionsView, 0);
            Grid.SetColumn(permissionsView, 0);
            Grid.SetColumnSpan(permissionsView, 5);
        }

        private void ShowVehiclesEvents(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear();

            var vehiclesEventsView = new VehiclesEventsView();
            MainContentArea.Children.Add(vehiclesEventsView);

            Grid.SetRow(vehiclesEventsView, 0);
            Grid.SetColumn(vehiclesEventsView, 0);
            Grid.SetColumnSpan(vehiclesEventsView, 5);
        }
    }
}
//ShowVehicleEvents