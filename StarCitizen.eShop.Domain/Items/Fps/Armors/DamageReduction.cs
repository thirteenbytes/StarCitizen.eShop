using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public record DamageReduction
{
    private DamageReduction(decimal value) =>
        Value = value;

    public decimal Value { get; init; }

    public string ValueFormatted
    {
        get
        {
            return Value.ToString("P2");
        }
    }

    public static DamageReduction Create(decimal value)
    {
        if(value < 0 || value > 100) 
        {         
            throw new ArgumentOutOfRangeException($"{value}");
        }

        return new DamageReduction(value);
    }
}
