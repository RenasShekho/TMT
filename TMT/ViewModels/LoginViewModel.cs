using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT.ViewModels
{
    internal class LoginViewModel:ViewModelBase
    {
        private string _email ;

        public string Email
        {
            get => _email;
            set => this.RaiseAndSetIfChanged(ref _email, value);
        }

        private string _password;

        public string Pasword
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

    }

}

