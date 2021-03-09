using Refit;
using System.Linq;
using System.Threading.Tasks;
using Vortex.Connector;

namespace Plc
{
    public partial class fbRest
    {
        private readonly IAnalysis API = RestService.For<IAnalysis>("https://sentim-api.herokuapp.com", new RefitSettings
        {
            ContentSerializer = new NewtonsoftJsonContentSerializer()
        });

        partial void PexConstructor(IVortexObject _, string _1, string _2)
        {
            RestCall.Initialize(DoTheRestCall);
        }

        private void DoTheRestCall() => Task.Run(async () =>
                                      {
                                          var response = await API
                                              .GetAnalysis(
                                                    new Request() { Text = ToAnalyse.Synchron }
                                                )
                                          .ConfigureAwait(false);
                                          var sentiments = response.Sentences.ToList().Select(x => x.Sentiment.Type);
                                          var joinedSentiments = string.Join(",", sentiments);
                                          AnalysisResult.Cyclic = joinedSentiments;
                                      });
    }
}
