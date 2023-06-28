using Avalonia.Controls;
using TMT.ViewModels;

namespace TMT.Views
{
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
            DataContext = new RegisterViewModel();
        }
    }
}
