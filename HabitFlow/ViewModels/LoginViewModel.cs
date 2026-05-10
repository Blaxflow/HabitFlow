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
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
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

        private Window _window;
        public ICommand ClearButton { get; }
        public ICommand NavButton { get; }
        public LoginViewModel(Window window)
        {
            _window = window;
            ClearButton = new RelayCommand(Clear);
            NavButton = new RelayCommand(Navigate);
        }
        private void Clear()
        {
            Username = "";
            Password = "";
        }
        private void Navigate()
        {
            var registration = new Registration();
            _window.Close();
            registration.Show();
        }
        
    }
}
