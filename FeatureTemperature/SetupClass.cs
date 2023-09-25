namespace FeatureTemperature
{
    public class SetupClass : ISetupClass
    {
        public string RemoteApiKey { get; set; }

        public SetupClass() 
        {
            RemoteApiKey = "94C995F8-42E8-40C5-9A1B-82E25E425D1F";
        }

        public string GetApiKey() 
        {
            return RemoteApiKey;
        }
    }
}