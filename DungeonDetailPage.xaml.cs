
namespace PixelStore;

public partial class DungeonDetailPage : ContentPage
{
    public DungeonDetailPage()
    {
        InitializeComponent();
    }

    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        bool valid = int.TryParse(quantityEntry.Text, out int quantity);

        if (valid && quantity > 0)
        {
            Cart.Names.Add("Dungeon Explorer");
            Cart.Quantities.Add(quantity);
            Cart.Prices.Add(14.99);

            messageLabel.Text = $"Added {quantity} x Dungeon Explorer";
            messageLabel.TextColor = Colors.MediumSpringGreen;
        }
        else
        {
            messageLabel.Text = "Enter a valid quantity.";
            messageLabel.TextColor = Colors.PaleGoldenrod;
        }
    }
}
