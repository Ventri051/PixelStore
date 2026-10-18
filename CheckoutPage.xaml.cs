
namespace PixelStore;

public partial class CheckoutPage : ContentPage
{
    public CheckoutPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        List<string> lines = new List<string>();
        double total = 0;

        for (int i = 0; i < Cart.Names.Count; i++)
        {
            lines.Add($"{Cart.Quantities[i]} x {Cart.Names[i]}");

            total += Cart.Quantities[i] * Cart.Prices[i];
        }

        cartList.ItemsSource = null;
        cartList.ItemsSource = lines;

        totalLabel.Text = $"Total: {total:C}";

        emptyLabel.IsVisible = Cart.Names.Count == 0;
    }

    private void OnCheckoutClicked(object sender, EventArgs e)
    {
        Cart.Names.Clear();
        Cart.Quantities.Clear();
        Cart.Prices.Clear();

        cartList.ItemsSource = null;
        emptyLabel.IsVisible = true;

        totalLabel.Text = "Total: $0.00";
        checkoutMessage.Text = "Thanks for your order!";
    }
}

