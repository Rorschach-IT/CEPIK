using CepikAppWinUI.Formulas;
using CepikAppWinUI.ViewModel;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Windows.Graphics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CepikAppWinUI.UserControlls
{
    public sealed partial class VehiclesView : UserControl
    {
        public VehiclesView()
        {
            this.InitializeComponent();

            var vehicleViewModel = new VehicleViewModel();
            DataContext = vehicleViewModel;

            vehicleViewModel.LoadVehiclesData();
        }

        private void AddNewVehicle(object sender, RoutedEventArgs e)
        {
            var window = new AddVehicleWindow();
            window.Activate();

            // Get native window handle
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hwnd);
            var appWindow = AppWindow.GetFromWindowId(windowId);

            // Set size
            int width = 1000;
            int height = 1400;
            appWindow.Resize(new SizeInt32(width, height));

            // Optional: center the window on screen
            var displayArea = DisplayArea.GetFromWindowId(windowId, DisplayAreaFallback.Primary);
            if (displayArea != null)
            {
                int x = (displayArea.WorkArea.Width - width) / 2;
                int y = (displayArea.WorkArea.Height - height) / 2;
                appWindow.Move(new PointInt32(x, y));
            }
        }

        private bool _sortAscending = true;

        private void HeaderTapped(object sender, TappedRoutedEventArgs e)
        {
            if (DataContext is VehicleViewModel viewModel && sender is FrameworkElement element && element.Tag is string propertyName)
            {
                viewModel.SortVehicles(propertyName, _sortAscending);
                _sortAscending = !_sortAscending; // Toggle for next sort
            }
        }
    }
}
