using System.Collections.ObjectModel;
using CepikAppWinUI.External;
using CommunityToolkit.Mvvm.ComponentModel;
using DataSet.Models;

namespace CepikAppWinUI.ViewModel
{
    public partial class CategoryViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Kategorie> categories = new();

        public void LoadCategoriesData()
        {
            DbLoader.LoadData(categories, () => new CentralnaEwidencjaContext());
        }
    }
}
