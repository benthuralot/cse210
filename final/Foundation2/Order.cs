public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        double shipping = 10;

        foreach (Product product in _products)
        {
           totalCost += product.CalculateProductCost();
        }

        return totalCost + shipping;
    }

    public string DisplayPackingLabel()
    {
        string packingLabel = "Packing Label:\n====================\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetID()} {product.GetName()}\n";
        }
        return packingLabel;
    }

    public string DisplayShippingLabel()
    {
        string name = _customer.GetName();
        Address address = _customer.GetAddress();
        string shippingLabel = "Shipping Label:\n====================\n";
        shippingLabel += $"{name}\n{address.Display()}";
        return shippingLabel;
    }


}
