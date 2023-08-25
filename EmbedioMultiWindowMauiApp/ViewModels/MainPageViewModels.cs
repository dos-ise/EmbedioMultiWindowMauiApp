using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EmbedioMultiWindowMauiApp.ViewModels
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModels
    {
        public MainPageViewModels()
        {
            source = "http://127.0.0.1:8080/index.html";
        }

        [ObservableProperty]
        private string source;

        [RelayCommand]
        public void OpenNewWindow()
        {
            Application.Current.OpenWindow(new Window(new MainPage()));
        }
    }
}
