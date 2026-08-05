using CommunityToolkit.Mvvm.ComponentModel;
using PageNavigationApp.Models;

namespace PageNavigationApp.ViewModels;

public partial class CustomersViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    [ObservableProperty]
    public partial int CustomerID { get; set; }

    public CustomersViewModel()
    {
        _pageModel = new PageModel();
        CustomerID = 100528;
    }

   //set { _pageModel.CustomerCount = value; OnPropertyChanged();
}


