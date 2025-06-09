using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class VehicleEventsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<VehiclesEvent> vehiclesEvents = new();

        public void LoadVehiclesEventsData()
        {
            DbLoader.LoadData(vehiclesEvents, () => new CentralnaEwidencjaContext());
        }
    }
}
