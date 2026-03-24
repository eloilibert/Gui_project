


//public class MainViewModel : ViewModelBase
//{
//    public string Greeting { get; } = "Yollaaa!";
//}
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GuiProject.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private string _telemetryData = "No data yet...";
    public string TelemetryData
    {
        get => _telemetryData;
        set
        {
            _telemetryData = value;
            OnPropertyChanged();
        }
    }

    private string _status = "Disconnected";
    public string Status
    {
        get => _status;
        set
        {
            _status = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}