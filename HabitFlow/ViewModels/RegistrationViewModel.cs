using HabitFlow.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private Window _window;
        public ICommand ClearCommand { get; }
        public ICommand NavButton { get; }
        public RegistrationViewModel (Window window)
        {
            _window = window;
            ClearCommand = new RelayCommand(Clear);
            NavButton = new RelayCommand(Navigation) ;
        }
        private void Clear()
        {
            Name = "";
            Email = "";
            Password = "";
            ConfirmPassword = "";
        }
        private void Navigation()
        {
            var Login = new Login();
            _window.Close();
            Login.Show();

        }

    }
}
