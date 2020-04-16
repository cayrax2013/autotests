using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AuthorizationCianPageTests.JsonDelete
{
    public class EnvironmentConstantsProvider
    {
        private const string _nameJsonFile = "person.json";

        public static void Provide(out EnvironmentConstants environmentConstants)
        {
            string jsonFile = File.ReadAllText(_nameJsonFile);
            environmentConstants = JsonSerializer.Deserialize<EnvironmentConstants>(jsonFile);
        }
    }
}
