using System.Collections.ObjectModel;
using System.Linq;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class VehicleViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Vehicles> vehicles = new();

        public void LoadVehiclesData()
        {
            DbLoader.LoadData(vehicles, () => new CentralnaEwidencjaContext());
        }

        // Method called when user clicks on column header
        public void SortVehicles(string propertyName, bool ascending = true)
        {
            var sorted = ascending
                ? Vehicles.OrderBy(v => GetPropertyValue(v, propertyName)).ToList()
                : Vehicles.OrderByDescending(v => GetPropertyValue(v, propertyName)).ToList();

            Vehicles.Clear();
            foreach (var vehicle in sorted)
                Vehicles.Add(vehicle);
        }

        private object GetPropertyValue(Vehicles vehicle, string propertyName)
        {
            return typeof(Vehicles).GetProperty(propertyName)?.GetValue(vehicle) ?? "";
        }
    }
}
