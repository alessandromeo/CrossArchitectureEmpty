namespace CrossArchitecture.CoreModel
{
    public class CoreModelEntity
    {
        public string Value { get; set; }

        public CoreModelEntity(string value)
        {
            Value = value;
        }

        public CoreModelEntity Escape()
        {
            return new CoreModelEntity(Value.Replace(" ", "-"));
        }
    }
}
