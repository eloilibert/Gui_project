using Avalonia.Controls;
using GuiProject.ViewModels;

namespace GuiProject.Views;
public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
