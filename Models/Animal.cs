namespace Models;

public abstract class Animal : ICreature
{
    private string _name = "unknown";
    private uint _age;
    private float _size;
    private bool _dead = false;

    protected abstract uint MaxAge { get; }
    protected abstract double MaxSize { get; }

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be blank");
            }

            _name = value;
        }
    }

    public uint Age
    {
        get => _age;
        set
        {
            if (value > MaxAge)
            {
                throw new AgeException(MaxAge);
            }

            _age = value;
        }
    }

    protected Animal(string name, uint age, float size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Size should be > 0");
        }

        Name = name;
        Age = age;
        _size = size;
    }

    public bool IsDead() => _dead;

    public string Print()
    {
        return $"{GetType().Name} [name:{_name}, age:{_age}, size:{_size:F}]";
    }

    public abstract void Eat<TCreature>(TCreature creature) where TCreature : ICreature;

    public void Die()
    {
        _dead = true;
    }

    public virtual void GetGrow()
    {
        var newSize = (float)(_size * 1.1d);
        if (newSize > MaxSize || newSize < _size)
        {
            throw new ArgumentOutOfRangeException($"{nameof(_size)} should be between {0} and {MaxSize}");
        }

        _size = newSize;
        Console.WriteLine($"\t{GetType().Name} {_name} new size == {_size}");
    }
}
