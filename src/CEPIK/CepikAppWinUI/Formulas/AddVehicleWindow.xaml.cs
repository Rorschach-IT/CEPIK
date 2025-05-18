using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CepikAppWinUI.Formulas
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddVehicleWindow : Window
    {
        public AddVehicleWindow()
        {
            this.InitializeComponent();
        }

        private void OnSaveClicked(object sender, RoutedEventArgs e)
        {
            string regNumber = RegNumberBox.Text;
            string vin = VinBox.Text;
            string brand = BrandBox.Text;
            string model = ModelBox.Text;
            string type = TypeBox.Text;
            string year = YearBox.Text;
            string engine = EngineBox.Text;
            string fuel = FuelBox.Text;
            string seats = SeatsBox.Text;
            string color = ColorBox.Text;
            var inspectionDate = InspectionDatePicker.Date;
            var status = (StatusBox.SelectedItem as ComboBoxItem)?.Content?.ToString();

            ContentDialog dialog = new()
            {
                Title = "Pojazd zapisany",
                Content = $"Dodano: {brand} {model} ({regNumber})",
                CloseButtonText = "OK",
                XamlRoot = this.Content.XamlRoot
            };

            _ = dialog.ShowAsync();
        }
    }
}
