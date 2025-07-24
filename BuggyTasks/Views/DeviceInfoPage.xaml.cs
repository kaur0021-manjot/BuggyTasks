using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace BuggyTasks.Views;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();

        // Set the labels defined in XAML
        ModelLabel.Text = $"Model: {DeviceInfo.Model}";
        PlatformLabel.Text = $"Platform: {DeviceInfo.Platform}";
    }
}

