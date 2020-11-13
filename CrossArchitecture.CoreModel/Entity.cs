namespace CrossArchitecture.CoreModel
{
    public class Entity
    {
        public string Name { get; private set; }

        public Entity(string name)
        {
            Name = name;
        }

        public void Escape()
        {
            Name = Name.Replace(" ", "_");
        }
    }
}
