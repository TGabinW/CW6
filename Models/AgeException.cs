namespace Models;

public class AgeException : Exception
{
    public uint AgeLimit;

    public AgeException(uint ageLimit, string? message = null) : base(message)
    {
        AgeLimit = ageLimit;
    }

    public AgeException(uint ageLimit, string? message, Exception? innerException) : base(message, innerException)
    {
        AgeLimit = ageLimit;
    }
}