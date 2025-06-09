using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class InsuranceAssignmentViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<AssigningInsurancesToVehicle> insuranceAssignments = new();

        public void LoadInsuranceAssignmentsData()
        {
            DbLoader.LoadData(insuranceAssignments, () => new CentralnaEwidencjaContext());
        }
    }
}
