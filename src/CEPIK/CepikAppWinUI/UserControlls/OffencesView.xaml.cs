using CepikAppWinUI.ViewModel;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CepikAppWinUI.UserControlls
{
    public sealed partial class OffencesView : UserControl
    {
        public OffencesView()
        {
            this.InitializeComponent();

            var offencesViewModel = new OffencesViewModel();
            DataContext = offencesViewModel;

            offencesViewModel.LoadOffencesData();
        }
    }
}
