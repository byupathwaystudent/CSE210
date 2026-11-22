
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Get product name
    public string GetName()
    {
        return _name;
    }

    // Get product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Calculate total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
