using StarCitizen.eShop.Domain.Items.Fps.ArmorItems;
using StarCitizen.eShop.Persistence.UnitTests.Fixtures;

namespace StarCitizen.eShop.Persistence.UnitTests
{
    public class ArmorEFUnitTests : IClassFixture<ApplicationDbContextFixture>
    {

        private readonly ApplicationDbContextFixture fixture;

        public ArmorEFUnitTests(ApplicationDbContextFixture fixture) =>
            this.fixture = fixture;


        [Fact]
        public async Task TemperaturePopulateTest()
        {

            // Arrange
            var lightArmor = new Armor(
                new ArmorId(Guid.NewGuid()),
                "Test Armor",
                "ManmufacturerName",
                ArmorType.Create("Light"),
                DamageReduction.Create(10),
                TemperatureStatistics.Create(-30, 190), 
                Capacity.Create(10), 
                Volume.Create(10),
                BiochemicalResistance.Create(0.10M),
                DistortionResistence.Create(0.02M),
                EnergyResistance.Create(0.05M), 
                PhysicalResistance.Create(0.21M),
                StunResistance.Create(0.12M),
                ThermalResistance.Create(0.04M));

            this.fixture.Context.Armors.Add(lightArmor);
            await this.fixture.Context.SaveChangesAsync();

            // Act
            var newArmor = this.fixture.Context.Armors.FirstOrDefault();

            // Assert
            Assert.NotNull(newArmor);
            Assert.NotNull(newArmor.TemperatureRange);

            Assert.Equal("Test Armor", newArmor.Name);
            Assert.Equal(-30, newArmor.TemperatureRange.MinimumTemperature);
            Assert.Equal(190, newArmor.TemperatureRange.MaximumTemperature);
        }
    }
}