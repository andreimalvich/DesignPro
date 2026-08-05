using CommunityToolkit.Mvvm.ComponentModel;
using PageNavigationApp.Models;

namespace PageNavigationApp.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    [ObservableProperty]
    public partial string ProductAvailability {  get; set; }


    public ProductsViewModel()
    {
        _pageModel = new PageModel();
        ProductAvailability = "Out of Stock";
    }
}
