
namespace PixelStore;

public partial class SpaceDetailPage : ContentPage
{
    public SpaceDetailPage()
    {
        InitializeComponent();
    }

    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        bool valid = int.TryParse(quantityEntry.Text, out int quantity);

        if (valid && quantity > 0)
        {
            Cart.Names.Add("Space Survivor");
            Cart.Quantities.Add(quantity);
            Cart.Prices.Add(24.99);

            messageLabel.Text = $"Added {quantity} x Space Survivor";
            messageLabel.TextColor = Colors.MediumSpringGreen;
        }
        else
        {
            messageLabel.Text = "Enter a valid quantity.";
            messageLabel.TextColor = Colors.PaleGoldenrod;
        }
    }
}
