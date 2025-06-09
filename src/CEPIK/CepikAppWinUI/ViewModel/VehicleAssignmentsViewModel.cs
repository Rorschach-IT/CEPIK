using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class VehicleAssignmentsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<AssigningOwnersToVehicle> vehicleAssignments = new();

        public void LoadVehicleAssignmentsData()
        {
            DbLoader.LoadData(vehicleAssignments, () => new CentralnaEwidencjaContext());
        }
    }
}
