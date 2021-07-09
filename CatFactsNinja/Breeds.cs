using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CatFactsNinja
{
    public class Breeds
    {
        [JsonProperty("current_page")]
        public string CurrentPage { get; set; }

        [JsonProperty("data")]
        public BreedDetail[] Data { get; set; }


        //public IList<BreedDetail> BreedDetails { get; set; }


        public class BreedDetail
        {
            [JsonProperty("breed")]
            public string Breed { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("origin")]
            public string Origin { get; set; }

            [JsonProperty("coat")]
            public string Coat { get; set; }

            [JsonProperty("pattern")]
            public string Pattern { get; set; }


        }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

    }
}
