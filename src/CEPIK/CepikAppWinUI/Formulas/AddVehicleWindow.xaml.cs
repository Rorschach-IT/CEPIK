using System;
using System.Collections.Generic;
using DataSet.Models;
using Microsoft.EntityFrameworkCore;
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

        private async void OnSaveClickedAsync(object sender, RoutedEventArgs e)
        {
            // Simple validation rules
            string reg = RegNumberBox.Text.Trim();
            string vin = VinBox.Text.Trim();
            string brand = BrandBox.Text.Trim();
            string model = ModelBox.Text.Trim();
            string type = TypeBox.Text.Trim();
            string yearText = YearBox.Text.Trim();
            string engine = EngineBox.Text.Trim();
            string fuel = FuelBox.Text.Trim();
            string seatsText = SeatsBox.Text.Trim();
            string color = ColorBox.Text.Trim();
            string status = (StatusBox.SelectedItem as ComboBoxItem)?.Content?.ToString();

            DateTime? inspectionDate = InspectionDatePicker.Date?.DateTime;

            // Collect errors
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(reg) || reg.Length > 10)
                errors.Add("Numer rejestracyjny jest wymagany i mo�e mie� maksymalnie 10 znak�w.");

            if (string.IsNullOrWhiteSpace(vin) || vin.Length != 17)
                errors.Add("VIN jest wymagany i musi mie� dok�adnie 17 znak�w.");

            if (string.IsNullOrWhiteSpace(brand) || brand.Length > 50)
                errors.Add("Marka jest wymagana i mo�e mie� maksymalnie 50 znak�w.");

            if (string.IsNullOrWhiteSpace(model) || model.Length > 50)
                errors.Add("Model jest wymagany i mo�e mie� maksymalnie 50 znak�w.");

            if (string.IsNullOrWhiteSpace(type) || type.Length > 50)
                errors.Add("Rodzaj jest wymagany i mo�e mie� maksymalnie 50 znak�w.");

            if (!short.TryParse(yearText, out short year) || year < 1886 || year > DateTime.Now.Year)
                errors.Add("Rok produkcji musi by� liczb� ca�kowit� z przedzia�u 1886 - obecny rok.");

            if (string.IsNullOrWhiteSpace(engine) || engine.Length > 100)
                errors.Add("Dane silnika s� wymagane i mog� mie� maksymalnie 100 znak�w.");

            if (string.IsNullOrWhiteSpace(fuel) || fuel.Length > 12)
                errors.Add("Rodzaj paliwa jest wymagany i mo�e mie� maksymalnie 12 znak�w.");

            if (!byte.TryParse(seatsText, out byte seats) || seats < 1 || seats > 100)
                errors.Add("Liczba miejsc musi by� liczb� ca�kowit� w przedziale 1 - 100.");

            if (string.IsNullOrWhiteSpace(color) || color.Length > 30)
                errors.Add("Kolor jest wymagany i mo�e mie� maksymalnie 30 znak�w.");

            if (string.IsNullOrWhiteSpace(status) || status.Length > 15)
                errors.Add("Status rejestracji jest wymagany i mo�e mie� maksymalnie 15 znak�w.");

            const string mainMessage = "Niepoprawane wype�nienie formularza";

            // Show errors
            if (errors.Count > 0)
            {
                string message = string.Join("\n", errors);
                var dialog = new ContentDialog
                {
                    Title = mainMessage,
                    Content = message,
                    CloseButtonText = "OK",
                    XamlRoot = (this.Content as FrameworkElement)?.XamlRoot
                };

                dialog.ShowAsync();
                return;
            }
            // If validation is passed, proceed with inserting new vehicle to table 'Pojazdy'
            else
            {
                try
                {
                    using (var context = new CentralnaEwidencjaContext())
                    {
                        var sql = "EXEC InsertPojazd @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11";

                        await context.Database.ExecuteSqlRawAsync(sql,
                            reg,
                            vin,
                            brand,
                            model,
                            type,
                            year,
                            engine,
                            fuel,
                            seats,
                            color,
                            inspectionDate.HasValue ? inspectionDate.Value : DBNull.Value,
                            status
                        );
                    }

                    var successDialog = new ContentDialog
                    {
                        Title = "Nowy pojazd",
                        Content = "Pomy�lnie dodano nowy pojazd.",
                        CloseButtonText = "OK",
                        XamlRoot = (this.Content as FrameworkElement)?.XamlRoot
                    };

                    await successDialog.ShowAsync();
                    this.Close();
                }
                catch (Exception ex)
                {
                    var errorDialog = new ContentDialog
                    {
                        Title = "B��d",
                        Content = $"Wyst�pi� b��d przy dodawaniu pojazdu:\n{ex.Message}",
                        CloseButtonText = "OK",
                        XamlRoot = (this.Content as FrameworkElement)?.XamlRoot
                    };

                    await errorDialog.ShowAsync();
                }

                return;
            }
        }
    }
}
