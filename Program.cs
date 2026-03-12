namespace Tp3_oop;


// public class ProductId // Exercice 8
// {
//     private static int nextId = 1; // Variable statique pour générer des IDs uniques
//     private int id;
//     private string name;
//     private double price;
//     public int Id {get { return id;} }
//     public string Name {get { return name;}}
//     public double Price {get { return price;}}

//     public ProductId(string name, double price) // Constructeur par défaut
//     {
//         this.id = nextId++;
//         this.name = name;
//         this.price = price;
//     }


class Program
{
    static void Main(string[] args)
    {
        // Exercice 1 bis Création d'un produit et affichage du ptoduit
        Product p1 = new Product();
        p1.SetName("Laptop");
        p1.SetPrice(1200);
        Console.WriteLine($"Product: {p1.GetName()}, Price: {p1.GetPrice()}");
        Product p2 = new Product("Mouse", 25);
        Console.WriteLine($"Product: {p2.GetName()}, Price: {p2.GetPrice()}");

        // Exercice 2 bis Création d'un client et affichage du client
        Customer c1 = new Customer();
        c1.SetFirstName("Alice");
        c1.SetLastName("Martin");
        c1.SetEmail("alice@example.com");
        Console.WriteLine($"Customer: {c1.GetFirstName()} {c1.GetLastName()}, Email: {c1.GetEmail()}");

        // Exercice 3 bis création d'une commande et affichage de la commande
        Order o1 = new Order();
        o1.SetOrderNumber(1001); // ici j'ai laissé l'écriture sans l'adapter à l'exercice 7
        o1.SetTotalAmount(350);
        o1.SetIsPaid(true);
        Console.WriteLine($"Order: {o1.GetOrderNumber()}, Total Amount: {o1.GetTotalAmount()}, Is Paid: {o1.GetIsPaid()}");

        Order o2 = new Order(c1, new List<Product> { p1, p2 });
        Console.WriteLine($"Client: {c1.GetFirstName()} {c1.GetEmail()}, Produit 1: {p1.GetName()} {p1.GetPrice()}, Produit 2: {p2.GetName()} {p2.GetPrice()}, Fournisseur");

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
        // ProductId prodId1 = new ProductId(1) { name = "Tablet", price = 600 }; // j'ai modifié l'Id qui était de 1 par 2 
        // Console.WriteLine($"Product ID: {prodId1.Id}, Name: {prodId1.Name}, Price: {prodId1.Price}");
    }
}