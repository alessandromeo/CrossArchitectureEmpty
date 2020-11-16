using Xunit;

namespace CrossArchitecture.CoreModel.UnitTest
{
    public class EntityEscapingTests
    {
        [Fact]
        public void Null_name_entity_is_not_escaped()
        {
            var entity = new Entity(null);
            entity.Escape();
            Assert.Null(entity.Name);
        }
    }
}
