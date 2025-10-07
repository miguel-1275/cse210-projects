class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _productID;
    }

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }
}
