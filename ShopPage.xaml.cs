
namespace PixelStore;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();

        productList.ItemsSource = new List<string>
        {
            "Adventure Quest",
            "Dungeon Explorer",
            "Space Survivor",
            "Dragon Legends"
        };
    }

    private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
        {
            return;
        }

        string product = e.CurrentSelection[0].ToString() ?? "";

        productList.SelectedItem = null;

        if (product == "Adventure Quest")
        {
            await Shell.Current.GoToAsync(nameof(AdventureDetailPage));
        }
        else if (product == "Dungeon Explorer")
        {
            await Shell.Current.GoToAsync(nameof(DungeonDetailPage));
        }
        else if (product == "Space Survivor")
        {
            await Shell.Current.GoToAsync(nameof(SpaceDetailPage));
        }
        else if (product == "Dragon Legends")
        {
            await Shell.Current.GoToAsync(nameof(DragonDetailPage));
        }
    }
}
