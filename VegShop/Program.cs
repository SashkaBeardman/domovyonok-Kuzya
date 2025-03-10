class Program
{
    static void Main()
    {
        VegetableShop shop = new VegetableShop();
        shop.AddVegetable(new Carrot(50));
        shop.AddVegetable(new Tomato(70));
        shop.AddVegetable(new Apple(10));
        shop.AddVegetable(new Potato(30, 1)); // Цена за кг
        shop.AddVegetable(new Cucumber(40, 1)); // Цена за кг

        Cart cart = new Cart();

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Показать продукты в магазине");
            Console.WriteLine("2. Добавить продукт в корзину");
            Console.WriteLine("3. Показать корзину");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    shop.ShowProducts();
                    break;
                case "2":
                    Console.Clear();
                    shop.ShowProducts();
                    Console.Write("Введите номер продукта для добавления в корзину: ");
                    if (int.TryParse(Console.ReadLine(), out int productIndex) && productIndex > 0 && productIndex <= shop.GetVegetables().Count)
                    {
                        Vegetable selected = shop.GetVegetables()[productIndex - 1];
                        if (selected is Potato || selected is Cucumber)
                        {
                            Console.Write("Введите количество кг: ");
                            if (double.TryParse(Console.ReadLine(), out double count) && count > 0)
                            {
                                if (selected is Potato)
                                    cart.AddToCart(new Potato(selected.Price / ((Potato)selected).Count, count));
                                else if (selected is Cucumber)
                                    cart.AddToCart(new Cucumber(selected.Price / ((Cucumber)selected).Count, count));
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод количества.");
                            }
                        }
                        else
                        {
                            cart.AddToCart(selected);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                    break;
                case "3":
                    Console.Clear();
                    cart.ShowCart();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор, попробуйте снова.");
                    break;
            }
        }
    }
}
