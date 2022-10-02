namespace Models;

public sealed class Diplodocus : Animal
{
    public Diplodocus(string name, uint age, float size) : base(name, age, size)
    {
    }

    protected override uint MaxAge { get; } = 30;
    protected override double MaxSize { get; } = 200;

    public override void Eat<TCreature>(TCreature creature)
    {
        if (IsDead())
        {
            throw new InvalidOperationException($"this {GetType().Name} {Name} is dead");
        }

        switch (creature)
        {
            case Tirex:
                throw new ArgumentException($"{nameof(Diplodocus)} cannot eat {nameof(Tirex)}");
            case Diplodocus:
                throw new ArgumentException($"{nameof(Diplodocus)} cannot eat another {nameof(Diplodocus)}");
            default:
                throw new NotImplementedException($"{creature.GetType()} is unknown");
        }
    }
}