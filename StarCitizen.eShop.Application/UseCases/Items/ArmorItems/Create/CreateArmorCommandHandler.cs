using MediatR;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

namespace StarCitizen.eShop.Application.UseCases.Items.ArmorItems.Create;

internal class CreateArmorCommandHandler : IRequestHandler<CreateArmorCommand>
{
    private readonly IArmorRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public CreateArmorCommandHandler(IArmorRepository repository, IUnitOfWork unitOfWork)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateArmorCommand request, CancellationToken cancellationToken)
    {

        // Populate Armor properties

        var armor = Armor.Create(            
            request.Name,
            request.Manufacturer,
            ArmorType.Create(request.Type, request.Weight),
            DamageReduction.Create(request.DamageReduction!.Value),
            TemperatureStatistics.Create(request.MinimumTemperature!.Value, request.MaximumTemperature!.Value),
            Capacity.Create(request.Capacity),
            Volume.Create(request.Volume),
            BiochemicalResistance.Create(request.BiochemicalResistance!.Value),
            DistortionResistence.Create(request.DistortionResistence!.Value),
            EnergyResistance.Create(request.EnergyResistance!.Value),
            PhysicalResistance.Create(request.PhysicalResistance!.Value),
            StunResistance.Create(request.StunResistance!.Value),
            ThermalResistance.Create(request.ThermalResistance!.Value));

        repository.Add(armor);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }    
}
