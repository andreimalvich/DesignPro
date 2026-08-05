using CommunityToolkit.Mvvm.ComponentModel;
using PageNavigationApp.Models;

namespace PageNavigationApp.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    [ObservableProperty]
    public partial bool Settings { get; set;  }


    public SettingsViewModel()
    {
        _pageModel = new PageModel();
        Settings = true;
    }

}

// Settings : set { _pageModel.LocationStatus = value; OnPropertyChanged(); }