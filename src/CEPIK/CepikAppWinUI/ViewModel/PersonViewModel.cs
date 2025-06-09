using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class PersonViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Person> people = new();

        public void LoadPersonsData()
        {
            DbLoader.LoadData(people, () => new CentralnaEwidencjaContext());
        }
    }
}
