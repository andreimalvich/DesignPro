using CommunityToolkit.Mvvm.ComponentModel;
using PageNavigationApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageNavigationApp.ViewModels;

public partial class OrdersViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    [ObservableProperty]
    public partial DateOnly DusplayOrderDate {  get; set; }

    public OrdersViewModel()
    {
        _pageModel = new PageModel();
        DusplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
    }
}
