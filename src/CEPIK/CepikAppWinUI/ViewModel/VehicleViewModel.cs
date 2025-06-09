using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class VehicleViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Pojazdy> vehicles = new();

        public void LoadVehiclesData()
        {
            DbLoader.LoadData(vehicles, () => new CentralnaEwidencjaContext());
        }
    }
}
