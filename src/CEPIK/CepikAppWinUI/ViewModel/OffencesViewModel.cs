using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class OffencesViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<OffensesOfPeopleAndVehicle> offences = new();

        public void LoadOffencesData()
        {
            DbLoader.LoadData(offences, () => new CentralnaEwidencjaContext());
        }
    }
}
