namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public sealed class ArmorTypeNotFoundException : Exception
{
    public ArmorTypeNotFoundException(params string[] errors)
        : base(string.Format("The armor type with = {0}", string.Join(", ", errors))) { }
}
