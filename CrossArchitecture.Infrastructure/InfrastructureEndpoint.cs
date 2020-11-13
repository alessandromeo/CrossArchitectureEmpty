using CrossArchitecture.CoreModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CrossArchitecture.Infrastructure
{
    public class InfrastructureEndpoint : IInfrastructureEndpoint
    {
        public string Send(IEnumerable<Entity> entities)
        {
            var destinationFile = Path.GetTempFileName();
            File.WriteAllText(destinationFile, entities.
                Select(e => $"\t{e.Name}").
                Prepend("Sent to file the following entities:").
                Aggregate(string.Empty, (acc, val) => $"{acc}{val}{Environment.NewLine}"));

            return destinationFile;
        }
    }
}
