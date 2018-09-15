using System;
using Newtonsoft.Json;

namespace FaithGrapper
{
    public class Data
    {
        [JsonProperty]
        public string ip { get; set; }
        
        [JsonProperty]
        public string city { get; set; }
        
        [JsonProperty]
        public string region { get; set; }
        
        [JsonProperty]
        public string region_code { get; set; }

        [JsonProperty]
        public string country { get; set; }
        
        [JsonProperty]
        public string country_name { get; set; }
        
        [JsonProperty]
        public string latitude { get; set; }
        
        [JsonProperty]
        public string longitude { get; set; }
    
        [JsonProperty]
        public string continent_code { get; set; }
        
        [JsonProperty]
        public bool in_eu { get; set; }
        
        [JsonProperty]
        public string postal { get; set; }
        
        [JsonProperty]
        public string timezone { get; set; }
        
        [JsonProperty]
        public string utc_offset { get; set; }
        
        [JsonProperty]
        public string country_calling_code { get; set; }

        [JsonProperty]
        public string currency { get; set; }

        [JsonProperty]
        public string languages { get; set; }

        [JsonProperty]
        public string asn { get; set; }
        
        [JsonProperty]
        public string org { get; set; }

    }
}