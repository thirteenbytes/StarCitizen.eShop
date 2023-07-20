namespace StarCitizen.eShop.Domain.Shared;

public class CurrencyMismatchException : Exception
{
    public CurrencyMismatchException(string message) : base(message) { }
}
