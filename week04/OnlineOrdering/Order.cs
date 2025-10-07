class Order
{
    private Customer _customer;
    private List<Product> _productsList = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
        _productsList = new List<Product>();
    }

    public void AddProduct(Product p)
    {
        _productsList.Add(p);
    }

    public double OrderTotalPrice()
    {
        double orderTotalCost = 0;

        foreach (Product p in _productsList)
        {
            orderTotalCost += p.TotalCost();
        }

        if (_customer.LivesInUSA() == true)
        {
            return orderTotalCost + 5;
        }
        else
        {
            return orderTotalCost + 35;
        }
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in _productsList)
        {
            label += $"{p.GetName()} - {p.GetID()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "";

        label += "Name:\n";
        label += $"{_customer.GetName()}\n";
        label += "Address:\n";
        label += _customer.GetAddress().DisplayAddress();

        return label;
    }
}
