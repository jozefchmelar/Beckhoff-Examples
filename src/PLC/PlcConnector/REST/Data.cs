using Newtonsoft.Json;
using System.Collections.Generic;

namespace Plc
{
    public class Request
    {    
        [JsonProperty("text")]
        public string Text { get; set; }
    }
    public partial class Analysis
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("sentences")]
        public List<Sentence> Sentences { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("polarity")]
        public double Polarity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Sentence
    {
        [JsonProperty("sentence")]
        public string SentenceSentence { get; set; }

        [JsonProperty("sentiment")]
        public Result Sentiment { get; set; }
    }

}
