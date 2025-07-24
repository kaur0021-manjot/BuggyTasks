using Microsoft.Maui.Controls;

namespace BuggyTasks;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("NewTaskPage", typeof(Views.NewTaskPage));
        Routing.RegisterRoute("tasklist", typeof(Views.TaskListPage));
        Routing.RegisterRoute("locationpage", typeof(Views.LocationPage));
        Routing.RegisterRoute("deviceinfopage", typeof(Views.DeviceInfoPage));
    }
}