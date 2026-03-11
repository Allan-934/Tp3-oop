namespace Tp3_oop;

public class Product // Exercice 1 
{
    private string name;
    private double price;

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
}

public class Customer // Exercice 2
{
    private string firstName;
    private string lastName;
    private string email;

    public string GetFirstName()
    {
        return firstName;
    }
    public void SetFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public string GetLastName()
    {
        return lastName;
    }
    public void SetLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public string GetEmail()
    {
        return email;
    }
    public void SetEmail(string newEmail)
    {
        email = newEmail;
    }
}

public class Order // Exercice 3 + Partie 3 Exercice 7 
{
    public int orderNumber;
    public double totalAmount;
    public bool isPaid;

    // public int GetOrderNumber()
    // {
    //     return orderNumber; // Lit la valeur de orderNumber
    // }
    // public void SetOrderNumber(int newOrderNumber)
    // {
    //     orderNumber = newOrderNumber; // Assigne une nouvelle valeur à orderNumber
    // }

    // public double GetTotalAmount()
    // {
    //     return totalAmount; // Lit la valeur de totalAmount 
    // }
    // public void SetTotalAmount(double newTotalAmount)
    // {
    //     totalAmount = newTotalAmount; // Assigne une nouvelle valeur à totalAmount
    // }

    // public bool GetIsPaid()
    // {
    //     return isPaid; // Lit la valeur de isPaid
    // }
    // public void SetIsPaid(bool newIsPaid)
    // {
    //     isPaid = newIsPaid; // Assigne une nouvelle valeur à isPaid 
    // }
}

public class Item // Exercice 4
{
    private string name;
    private double price;
    private int quantity;

    public string Name
    {
        get { return name; } 
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}

public class Supplier // Exercice 5
{
    private string name;
    private string city;
    private string phone;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
}

public class Category // Exercice 6
{
    private string name;
    private string description;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
}

public class ProductId // Exercice 8
{
    private int id;
    private string name;
    private double price;
    public int Id {get { return id;} }
    public string Name {get { return name;}}
    public double Price {get { return price;}}

}

class Program
{
    static void Main(string[] args)
    {
        // Exercice 1 bis Création d'un produit et affichage du ptoduit
        Product p1 = new Product();
        p1.SetName("Laptop");
        p1.SetPrice(1200);
        Console.WriteLine($"Product: {p1.GetName()}, Price: {p1.GetPrice()}");

        // Exercice 2 bis Création d'un client et affichage du client
        Customer c1 = new Customer();
        c1.SetFirstName("Alice");
        c1.SetLastName("Martin");
        c1.SetEmail("alice@example.com");
        Console.WriteLine($"Customer: {c1.GetFirstName()} {c1.GetLastName()}, Email: {c1.GetEmail()}");

        // Exercice 3 bis création d'une commande et affichage de la commande
        Order o1 = new Order();
        o1.orderNumber = 1001; // ici j'ai laissé l'écriture sans l'adapter à l'exercice 7
        o1.totalAmount = 350;
        o1.isPaid = true;
        Console.WriteLine($"Order: {o1.orderNumber}, Total Amount: {o1.totalAmount}, Is Paid: {o1.isPaid}");

        // Exercice 4 bis création d'un item et affichage de l'item 
        Item i1 = new Item { Name = "Smartphone", Price = 800, Quantity = 3 }; 
        Console.WriteLine($"Item: {i1.Name}, Price: {i1.Price}, Quantity: {i1.Quantity}");  

        // Exercice 5 bis création d'un fournisseur et affichage du fournisseur
        Supplier s1 = new Supplier { Name = "TechSupply", City = "Paris", Phone = "0102030405" }; 
        Console.WriteLine($"Supplier: {s1.Name}, Contact Info: {s1.City}, Phone: {s1.Phone}");

        // Exercice 6 bis création des catégories et affichage des catégories
        Category cat1 = new Category { Name = "Electronics", Description = "Electronic devices" }; 
        Console.WriteLine($"Category: {cat1.Name}, Description: {cat1.Description}");
        Category cat2 = new Category { Name = "Books", Description = "Books and literature" };
        Console.WriteLine($"Category: {cat2.Name}, Description: {cat2.Description}");
        Category cat3 = new Category { Name = "Clothing", Description = "Clothes and accessories" };
        Console.WriteLine($"Category: {cat3.Name}, Description: {cat3.Description}"); 

        // Exercice 8 bis création d'un produit et affichage du produit
        ProductId prodId1 = new ProductId() { id = 2, name = "Tablet", price = 600 };
        Console.WriteLine($"Product ID: {prodId1.Id}, Name: {prodId1.Name}, Price: {prodId1.Price}");
    }
}