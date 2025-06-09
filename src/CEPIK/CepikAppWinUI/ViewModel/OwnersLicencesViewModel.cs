using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class OwnersLicencesViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<AssigningOwnersToLicence> ownersLicences = new();

        public void LoadOwnersLicencesData()
        {
            DbLoader.LoadData(ownersLicences, () => new CentralnaEwidencjaContext());
        }
    }
}
