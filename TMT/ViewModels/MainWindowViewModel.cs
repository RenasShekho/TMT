using ReactiveUI;

namespace TMT.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        //public string Text { get; set; } = "long live the pizza";

        ViewModelBase content;

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public MainWindowViewModel()
        {
            Content = new LoginViewModel();
        }

        public void SwitchPageToRegister()
        {
            Content = new RegisterViewModel();
        }
        public void SwitchPageToLogin()
        {
            Content = new LoginViewModel();
        }
    }
}