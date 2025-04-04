using System.Globalization;

public class ProductViewModel
{
    private static CultureInfo PriceCulture = new CultureInfo("en-US");

    public string SummaryText {get;}
    public ProductViewModel(string name, decimal unitPrice)
    {
        this.SummaryText = string.Format(PriceCulture, "{0} ({1:C})", name, unitPrice);
    }
}