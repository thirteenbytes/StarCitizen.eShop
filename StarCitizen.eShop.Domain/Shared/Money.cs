﻿namespace StarCitizen.eShop.Domain.Shared;

public sealed record Money
{
    private Money(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }

    private Money(decimal amount, string currencyCode, ICurrencyLookup currencyLookup)
    {
        if (string.IsNullOrEmpty(currencyCode))
            throw new ArgumentNullException(
                nameof(currencyCode), "Currency code must be specified");

        var currency = currencyLookup.FindCurrency(currencyCode);
        if (currency is null)
        {
            throw new ArgumentNullException(nameof(currency), "Currency request is not found");
        }

        if (decimal.Round(amount, currency.DecimalPlaces) != amount)
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                $"Amount in {currencyCode} cannot have more than {currency.DecimalPlaces} decimals");

        Amount = amount;
        Currency = currency;
    }
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }

    public static Money FromDecimal(decimal amount, string currency, ICurrencyLookup currencyLookup) =>
        new Money(amount, currency, currencyLookup);
    

    public static Money FromString(string amount, string currency,
            ICurrencyLookup currencyLookup) =>
            new Money(decimal.Parse(amount), currency, currencyLookup);

    public Money Add(Money summand)
    {
        if (Currency != summand.Currency)
            throw new CurrencyMismatchException(
                "Cannot sum amounts with different currencies");

        return new Money(Amount + summand.Amount, Currency);
    }

    public Money Subtract(Money subtrahend)
    {
        if (Currency != subtrahend.Currency)
            throw new CurrencyMismatchException(
                "Cannot subtract amounts with different currencies");

        return new Money(Amount - subtrahend.Amount, Currency);
    }

    public static Money operator +(Money summand1, Money summand2) =>
        summand1.Add(summand2);

    public static Money operator -(Money minuend, Money subtrahend) =>
        minuend.Subtract(subtrahend);

    public override string ToString() => $"{Currency.Code} {Amount}";

}
