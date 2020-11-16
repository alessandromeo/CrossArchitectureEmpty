using System;

namespace CrossArchitecture.CoreModel
{
    public class Entity
    {
        public string Name { get; private set; }

        public Entity(string name)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException(
                    $"{nameof(name)} argument cannot be an empty string",
                    nameof(name));
            }
            Name = name;
        }

        public void Escape()
        {
            Name = Name?.Replace(" ", "_");
        }
    }
}
