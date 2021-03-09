using MongoRepository;

namespace Plc
{
    public partial class DataManager
    {
        private static readonly MongoRepository<PlainstSettings> DataManagerRepository = new MongoRepository<PlainstSettings>();

        partial void PexConstructor(Vortex.Connector.IVortexObject _, string _1, string _2)
        {
            this.SaveSettings.Initialize(SaveSettingsMethods);
        }

        private void SaveSettingsMethods()
        {
            var plainData = Settings.CreatePlainerType();
            Settings.FlushOnlineToPlain(plainData);
            DataManagerRepository.Add(plainData);
        }
    }
}