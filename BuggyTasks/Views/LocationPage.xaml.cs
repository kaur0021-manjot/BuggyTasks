using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;

namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation();
    }

    async Task GetLocation()
    {
        var location = await Geolocation.GetLastKnownLocationAsync();

        if (location != null)
        {
            LatitudeLabel.Text = $"Latitude: {location.Latitude}";
            LongitudeLabel.Text = $"Longitude: {location.Longitude}";
        }
        else
        {
            LatitudeLabel.Text = "Latitude: Not available";
            LongitudeLabel.Text = "Longitude: Not available";
        }
    }
}