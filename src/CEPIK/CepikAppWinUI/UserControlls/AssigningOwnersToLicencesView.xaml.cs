using CepikAppWinUI.ViewModel;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CepikAppWinUI.UserControlls
{
    public sealed partial class AssigningOwnersToLicencesView : UserControl
    {
        public AssigningOwnersToLicencesView()
        {
            this.InitializeComponent();

            var ownersLicencesViewModel = new OwnersLicencesViewModel();
            DataContext = ownersLicencesViewModel;

            ownersLicencesViewModel.LoadOwnersLicencesData();
        }
    }
}
