using Newtonsoft.Json;
using System.IO;

namespace PlcConnector.Secret
{
    public class Secrets
    {
        public static Secrets Instance => new Secrets().Load();

        public string EmailUser { get; set; }
        public string EmailPassword { get; set; }
        public string TwillioSid { get; set; }
        public string TwillioAuth { get; set; }

        public Secrets()
        {
        }

        public Secrets Load()
        {
            const string fileName = "secrets.json";
            if (File.Exists(fileName))
            {
                return JsonConvert.DeserializeObject<Secrets>(File.ReadAllText("secrets.json"));
            }
            else
            {
                var safe = JsonConvert.SerializeObject(this,Formatting.Indented);
                File.WriteAllText("secrets.json", safe);
                return this;
            }
        }
    }
}
