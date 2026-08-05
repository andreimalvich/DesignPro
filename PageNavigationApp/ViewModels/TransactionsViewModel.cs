using CommunityToolkit.Mvvm.ComponentModel;
using PageNavigationApp.Models;

namespace PageNavigationApp.ViewModels;

public partial class TransactionsViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    [ObservableProperty]
    public partial decimal TransactionAmount {  get; set; }

    public TransactionsViewModel()
    {
        _pageModel = new PageModel();
        TransactionAmount = 5638;
    }
}
