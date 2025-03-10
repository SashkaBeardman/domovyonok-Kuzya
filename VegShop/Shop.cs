using System;
using System.Collections.Generic;

public abstract class Vegetable
{
    public string Name { get; private set; }
    protected double BasePrice;

    public virtual double Price => BasePrice;

    protected Vegetable(string name, double basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }
}

public class Carrot : Vegetable
{
    public Carrot(double basePrice) : base("Морковь", basePrice) { }
}

public class Tomato : Vegetable
{
    public Tomato(double basePrice) : base("Томат", basePrice) { }
}
public class Apple : Vegetable
{
    public Apple(double basePrice) : base("Яблоко", basePrice) { }
}

public class Potato : Vegetable
{
    public double Count { get; private set; }

    public override double Price => BasePrice * Count;

    public Potato(double basePrice, double count) : base("Картофель", basePrice)
    {
        Count = count;
    }
}

public class Cucumber : Vegetable
{
    public double Count { get; private set; }

    public override double Price => BasePrice * Count;

    public Cucumber(double basePrice, double count) : base("Огурец", basePrice)
    {
        Count = count;
    }
}

public class VegetableShop
{
    private List<Vegetable> vegetables = new List<Vegetable>();

    public void AddVegetable(Vegetable vegetable)
    {
        vegetables.Add(vegetable);
    }

    public void ShowProducts()
    {
        double totalCost = 0;
        Console.WriteLine("Продукты в магазине:");
        for (int i = 0; i < vegetables.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {vegetables[i].Name}: {vegetables[i].Price} UAH.");
            totalCost += vegetables[i].Price;
        }
        Console.WriteLine($"Общая стоимость всех продуктов: {totalCost} UAH.");
    }

    public List<Vegetable> GetVegetables()
    {
        return vegetables;
    }
}

public class Cart
{
    private List<Vegetable> cartItems = new List<Vegetable>();

    public void AddToCart(Vegetable vegetable)
    {
        cartItems.Add(vegetable);
        Console.WriteLine($"{vegetable.Name} добавлен в корзину.");
    }

    public void ShowCart()
    {
        if (cartItems.Count == 0)
        {
            Console.WriteLine("Корзина пуста.");
            return;
        }

        double totalCost = 0;
        Console.WriteLine("Корзина покупок:");
        foreach (var vegetable in cartItems)
        {
            Console.WriteLine($"{vegetable.Name}: {vegetable.Price} UAH.");
            totalCost += vegetable.Price;
        }
        Console.WriteLine($"Общая стоимость корзины: {totalCost} UAH.");
    }
}
