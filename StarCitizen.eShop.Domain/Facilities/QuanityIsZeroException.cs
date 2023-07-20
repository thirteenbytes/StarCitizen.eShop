namespace StarCitizen.eShop.Domain.Facilities;

public class QuanityIsZeroException : Exception
{
    public QuanityIsZeroException()
        : base($"The qualitity is already at zero inventory") { }
}

