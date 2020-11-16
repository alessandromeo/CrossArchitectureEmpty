using System;
using Xunit;

namespace CrossArchitecture.CoreModel.UnitTest
{
    public class EntityConstructionTests
    {
        [Fact]
        public void Can_build_entities_with_null_name()
        {
            new Entity(null);
        }

        [Fact]
        public void Cannot_build_entities_with_empty_name()
        {
            Assert.ThrowsAny<Exception>(() => new Entity(string.Empty));
        }

        [Theory]
        [InlineData("01235854032105161056120")]
        [InlineData("  entity name with spaces  and   special chars!!##--%||!   ")]
        [InlineData(null)]
        public void Entity_constructor_sets_entity_name(string entityName)
        {
            var entity = new Entity(entityName);
            Assert.Equal(entityName, entity.Name);
        }
    }
}
