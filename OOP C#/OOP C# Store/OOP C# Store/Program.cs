using System;
using System.Collections.Generic;
//class
public interface IDiscountable
{
    double ApplyDiscount(double originalPrice);
}
public class Product //
{
    public string Name { get; }
    public double Price { get; }


    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: ${Price}");
    }
    public void DisplayInfo(int a, int b)
    {
        Console.WriteLine($"Product: {a}, Price: ${b}");
    }
}


public sealed class Grocery : Product
{
    public Grocery(string name, double price) : base(name, price)
    {
    }
}

public abstract class PaymentMethod
{
    public abstract void ProcessPayment(double amount);
    abstract public void x();
}


public class CreditCard : PaymentMethod
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment for ${amount}");
    }
    public override void x()
    {

    }
}

public class Cash : PaymentMethod
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Collecting cash payment of ${amount}");
    }
    public override void x()
    {
        throw new NotImplementedException();
    }
}


public class Customer
{
    public string Name { get; }
    private List<Product> shoppingCart;


    public Customer(string name)
    {
        Name = name;
        shoppingCart = new List<Product>();
    }


    public void AddToCart(Product product)
    {
        shoppingCart.Add(product);
    }


    public void DisplayCart()
    {
        Console.WriteLine($"Shopping Cart of {Name}:");
        foreach (var item in shoppingCart)
        {
            item.DisplayInfo();
        }
    }


    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in shoppingCart)
        {
            total += item.Price;
        }
        return total;
    }

    public void ProcessPayment(PaymentMethod paymentMethod)
    {
        double total = CalculateTotal();
        paymentMethod.ProcessPayment(total);
    }


}

class Program
{
    static void Main(string[] args)
    {

        Product apple = new Product("Apple", 1.5);
        Product milk = new Product("Milk", 2.0);
        Grocery bread = new Grocery("Bread", 1.0);


        Customer customer = new Customer("Ahmed Maarouf");


        customer.AddToCart(apple);
        customer.AddToCart(milk);
        customer.AddToCart(bread);


        customer.DisplayCart();


        PaymentMethod paymentMethod = new CreditCard();
        customer.ProcessPayment(paymentMethod);

        Console.ReadLine();

    }
}
