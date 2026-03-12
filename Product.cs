public class Product // Exercice 1 
{
    private string name = string.Empty;
    private double price;
    private Supplier? supplier; // tp 4 Partie 3.3

    public string GetName()
    {
        return name;
    }
    public void SetName(string newName)
    {
        name = newName;
    }

    public double GetPrice()
    {
        return price;
    }
    public void SetPrice(double newPrice)
    {
        price = newPrice;
    }

    public Product() // constructeur vide 
    {
        
    }

    public Product(string name, double price) // constructeur avec paramètres
    {
        this.name = name;
        this.price = price;
    }

    public Product( Supplier supplier) // constructeur avec paramètres Supplier 
    {
        this.supplier = supplier;
    }
}