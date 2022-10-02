namespace Models;

public interface ICreature
{
    public string Name
    {
        get;
    }

    public string Print();

    public void Eat<TCreature>(TCreature creature) where TCreature : ICreature;

    public void Die();
}
