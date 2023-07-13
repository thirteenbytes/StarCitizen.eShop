using MediatR;

namespace StarCitizen.eShop.Application.UseCases.Items.ArmorItems.Create;

public record CreateArmorCommand(
    string Name,
    string Type,
    string Manufacturer,
    decimal? DamageReduction,
    decimal? MinimumTemperature,
    decimal? MaximumTemperature,
    decimal? Capacity,
    decimal? Volume,
    decimal? BiochemicalResistance,
    decimal? DistortionResistence,
    decimal? EnergyResistance,
    decimal? PhysicalResistance,
    decimal? StunResistance,
    decimal? ThermalResistance
    ) : IRequest;

