using resturant_managment;

while (true)
{
    try
    {
        Run();
    }catch(Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}
void Run()
{
    Console.WriteLine("choose an option:\n1.add pasta\n2.add pizza\n3.reamove pasta\n4.reamove pizza\n5show pastas" +
        "\n6.show pizzas\n7order pasta\n8.order pizza");
    var input = int.Parse(Console.ReadLine()!);
    switch (input)
    {
        case 1:
            {
                Console.WriteLine("enter pasta name");
                var name = Console.ReadLine();
                Console.WriteLine("enter price");
                var price = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter stock");
                var stock = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter volume");
                var volume = int.Parse(Console.ReadLine()!);
                OrderManagment.AddPasta(name, price, stock, volume);
                break;

            }
        case 2:
            {
                Console.WriteLine("enter pizza name");
                var name = Console.ReadLine();
                Console.WriteLine("enter price");
                var price = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter stock");
                var stock = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter slice");
                var slice = int.Parse(Console.ReadLine()!);
                OrderManagment.AddPizza(name, price, stock, slice);
                break;
            }
        case 3:
            {
                Console.WriteLine("enter pasta name");
                var name = Console.ReadLine()!;
                OrderManagment.ReamovePasta(name);
                break;
            }
        case 4:
            {
                Console.WriteLine("enter pizza name");
                var name = Console.ReadLine()!;
                OrderManagment.ReamovePizza(name);
                break;
            }
        case 5:
            {
                foreach(var pasta in OrderManagment.GetPastas())
                {
                    Console.WriteLine($"name={pasta.Name},price={pasta.Price}," +
                        $"stock={pasta.Stock},volume={pasta.Volume}");
                }
                break;
            }
        case 6:
            {
                foreach (var pizza in OrderManagment.GetPizzas())
                {
                    Console.WriteLine($"name={pizza.Name},price={pizza.Price}," +
                        $"stock={pizza.Stock},slice={pizza.Slice}");
                }

                break;
            }
        case 7:
            {
                Console.WriteLine("enter pasta name");
                var name = Console.ReadLine()!;
                OrderManagment.OrderPasta(name);
                break;
            }
        case 8:
            {
                Console.WriteLine("enter pizza name");
                var name = Console.ReadLine()!;
                OrderManagment.OrderPizza(name);
                break;
            }
    }
}