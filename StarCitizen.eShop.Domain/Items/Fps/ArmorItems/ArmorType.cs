namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public record ArmorType
{
    private ArmorType(ArmorTypeEnum typeValue, ArmorWeightEnum weightValue)
    {
        TypeValue = typeValue;
        WeightValue = weightValue;
    }

    public ArmorTypeEnum TypeValue { get; init; }
    public ArmorWeightEnum WeightValue { get; init; }

    public static ArmorType Create(string type, string weight)
    {
        var typeResult = Enum.TryParse(type, out ArmorTypeEnum typeValue);
        var weightResult = Enum.TryParse(weight, out ArmorWeightEnum weightValue);

        if(typeResult && weightResult)
        {
            return new ArmorType(typeValue, weightValue);
        }

        throw new ArmorTypeNotFoundException(type, weight);        
    }
    public override string ToString()
    {
        return $"{WeightValue} {TypeValue}";
    }
}

public enum ArmorTypeEnum
{
    Undersuit = 0,
    Helmet = 1,
    Arms = 2,
    Torso = 3,
    Backpack = 4,
    Legs = 5,    
}

public enum ArmorWeightEnum
{
    Flight = 0,
    Light = 1, 
    Medium = 2,
    Heavy = 3
}
