using CommunityToolkit.Mvvm.ComponentModel;
using PageNavigationApp.Models;

namespace PageNavigationApp.ViewModels;

public partial class ShipmentsViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    [ObservableProperty]
    public partial TimeOnly ShipmentTracking {  get; set; }


    public ShipmentsViewModel()
    {
        _pageModel = new PageModel();
        TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
        ShipmentTracking = time;
    }
}
