
namespace PixelStore;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(AdventureDetailPage), typeof(AdventureDetailPage));
        Routing.RegisterRoute(nameof(DungeonDetailPage), typeof(DungeonDetailPage));
        Routing.RegisterRoute(nameof(SpaceDetailPage), typeof(SpaceDetailPage));
        Routing.RegisterRoute(nameof(DragonDetailPage), typeof(DragonDetailPage));
    }
}

