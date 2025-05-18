using CepikAppWinUI.Formulas;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
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
    }
}
