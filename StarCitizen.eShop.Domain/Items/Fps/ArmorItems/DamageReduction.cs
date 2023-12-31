﻿namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public sealed record DamageReduction
{
    private DamageReduction(decimal value) =>    
        Value = value;
           
    private DamageReduction() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static DamageReduction NotApplicable = new DamageReduction { InUse = false };

    public override string ToString()
    {
        return Value.ToString("P2");
    }    

    public static DamageReduction Create(decimal? value)
    {
        if(value.HasValue)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException($"{value}");
            }

            return new DamageReduction(value.Value);
        }

        return NotApplicable;        
    }
}
