
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
            messageLabel.Text = "Added to cart!";
            messageLabel.TextColor = Colors.MediumSpringGreen;
        }
        else
        {
            messageLabel.Text = "Enter a valid quantity.";
            messageLabel.TextColor = Colors.PaleGoldenrod;
        }
    }
}
