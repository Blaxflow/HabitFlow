using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HabitFlow.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private string _name;
        private string _email;
        private string _password;
        private string _confirmPassword;


        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }

        public ICommand ClearCommand { get; }
        public RegistrationViewModel ()
        {
            ClearCommand = new RelayCommand(Clear);
        }
        private void Clear()
        {
            Name = "";
            Email = "";
            Password = "";
            ConfirmPassword = "";
        }
    }
}
