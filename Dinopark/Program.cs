using Models;
namespace Host;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Добры дзень. Сардэчна запрашаем у Динопарк" + (args.Length > 0 ? $" args: [{string.Join(',', args)}]" : string.Empty));

        var park = new ICreature[]
        {
            new Tirex("Di", 22, 450),
            new Tirex("Adolf", 49, 350),
            new Diplodocus("Sam", 15, 40),
            new Diplodocus("Piter", 18, 150),
            new Diplodocus("Sara", 11, 80),
            new Diplodocus("Avraam", 12, 100),
        };

        for (var i = 0; i < park.Length - 1; i++)
        {
            for (var j = i + 1; j < park.Length; j++)
            {
                DoAction(park[i], park[j]);
            }
        }
    }

    private static void DoAction(ICreature? creature1, ICreature? creature2)
    {
        Console.WriteLine("\n--action-------");
        Console.WriteLine($"{nameof(creature1)} {creature1.Print()}");
        Console.WriteLine($"{nameof(creature2)} {creature2.Print()}");
        try
        {
            creature1.Eat(creature2);
        }
        catch (AgeException e)
        {
            Console.WriteLine($"Age exception with AgeLimit == {e.AgeLimit}\n\t" + e.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("------------\n");
    }
}