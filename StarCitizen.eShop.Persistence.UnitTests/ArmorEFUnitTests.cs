using Microsoft.EntityFrameworkCore.Metadata;
using StarCitizen.eShop.Domain.Items.Fps.Armors;
using StarCitizen.eShop.Persistence.UnitTests.Fixtures;
using System.Runtime.CompilerServices;

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
                ArmorType.Create("Light"),
                DamageReduction.Create(10),
                TemperatureRange.Create(-30, 190), Capacity.Create(10), Volume.Create(10));

            this.fixture.Context.Armors.Add(lightArmor);
            await this.fixture.Context.SaveChangesAsync();

            // Act
            var newArmor = this.fixture.Context.Armors.FirstOrDefault();

            // Assert
            Assert.NotNull(newArmor);
            Assert.NotNull(newArmor.TemperatureRange);
            Assert.Equal(-30, newArmor.TemperatureRange.MinimumTemperature);
            Assert.Equal(190, newArmor.TemperatureRange.MaximumTemperature);
        }
    }
}