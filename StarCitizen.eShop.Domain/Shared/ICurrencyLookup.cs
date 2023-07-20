namespace StarCitizen.eShop.Domain.Shared;

public interface ICurrencyLookup
{
    Currency FindCurrency(string currencyCode);
}
