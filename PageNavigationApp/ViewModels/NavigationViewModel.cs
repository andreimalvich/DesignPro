using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PageNavigationApp.ViewModels;

public partial class NavigationViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableObject? CurrentView { get; set; }

    [RelayCommand] private void GoToHome() => CurrentView = new HomeViewModel();
    [RelayCommand] private void GoToCustomers() => CurrentView = new CustomersViewModel();
    [RelayCommand] private void GoToProducts() => CurrentView = new ProductsViewModel();
    [RelayCommand] private void GoToOrders() => CurrentView = new OrdersViewModel();
    [RelayCommand] private void GoToTransactions() => CurrentView = new TransactionsViewModel();
    [RelayCommand] private void GoToShipments() => CurrentView = new ShipmentsViewModel();
    [RelayCommand] private void GoToSettings() => CurrentView = new SettingsViewModel();

    public NavigationViewModel()
    {

        // Startup Page
        CurrentView = new HomeViewModel();
    }


}
