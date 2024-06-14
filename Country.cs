using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProjectJsonToCsvConverter
{
    public class Country
    {
        [JsonProperty("name")]
        public CountryName Name { get; set; }

        public string Region { get; set; }
        public string Subregion { get; set; }

        public string[] Capital { get; set; }
    }
}
