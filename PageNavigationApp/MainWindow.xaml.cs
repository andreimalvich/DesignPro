using System.Windows;

namespace PageNavigationApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void CloseApp_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

}