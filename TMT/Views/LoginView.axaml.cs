using Avalonia.Controls;
using TMT.ViewModels;

namespace TMT.Views
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();

        }
    }
}
