using System.Runtime.Intrinsics.Arm;

namespace Models;

public sealed class Tirex : Animal
{
    public Tirex(string name, uint age, float size) : base(name, age, size)
    {
    }

    protected override uint MaxAge { get; } = 50;
    protected override double MaxSize { get; } = 800;

    public override void Eat<TCreature>(TCreature creature)
    {
        if (IsDead())
        {
            throw new InvalidOperationException($"this {GetType().Name} {Name} is dead");
        }

        switch (creature)
        {
            case Tirex Tirex:
                throw new ArgumentException($"{nameof(Tirex)} {Name} cannot eat {nameof(Tirex)} {Tirex.Name}");
            case Diplodocus Dip:
                if (Dip.IsDead())
                {
                    throw new InvalidOperationException($"{nameof(Diplodocus)} {Dip.Name} already dead");
                }
                Dip.Die();
                Console.WriteLine($"{nameof(Tirex)} {Name} ate {nameof(Diplodocus)} {Dip.Name}");

                GetGrow();
                break;
            default:
                throw new NotImplementedException($"{creature.GetType()} is unknown");
        }
    }
}