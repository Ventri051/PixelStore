
namespace PixelStore;

public partial class AdventureDetailPage : ContentPage
{
    public AdventureDetailPage()
    {
        InitializeComponent();
    }

    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        bool valid = int.TryParse(quantityEntry.Text, out int quantity);

        if (valid && quantity > 0)
        {
            Cart.Names.Add("Adventure Quest");
            Cart.Quantities.Add(quantity);
            Cart.Prices.Add(19.99);

            messageLabel.Text = $"Added {quantity} x Adventure Quest";
            messageLabel.TextColor = Colors.MediumSpringGreen;
        }
        else
        {
            messageLabel.Text = "Enter a valid quantity.";
            messageLabel.TextColor = Colors.PaleGoldenrod;
        }
    }
}
