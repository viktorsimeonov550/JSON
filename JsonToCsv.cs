using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectJsonToCsvConverter
{
    public static class JsonToCsv
    {
        static List<Country> countries = new List<Country>();

        internal static void CheckUserInput(string userIntput)
        {
            if (string.IsNullOrWhiteSpace(userIntput.TrimEnd('/')))
            {
                throw new Exception("User input should not be empty...");
            }
        }

        public static bool IsApiPathValid()
        {
            string[] allApiPaths = Enum.GetNames(typeof(ApiPaths));
            string[] allApiPaths2 = new string[]
            {
                "Name",
                "Region",
                "Subregion",
                "Capital",
            };

            //TODO:
            return true;
        }

        internal static string GetJson(string api, string userIntput)
        {
            Task<HttpResponseMessage> response = GetResponse(api, userIntput);

            HttpStatusCode statusCode = response.Result.StatusCode;
            if (statusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("No result found");
            }

            if (statusCode != HttpStatusCode.OK)
            {
                throw new Exception("Error! Try again!");
            }

            string responseAsString = ReadResponseAsStringAsync(response);

            try
            {
                countries = DeserializeJson(responseAsString);
            }
            catch (Exception)
            {
                throw new Exception("Invalid Json...");
            }

            string countriesAsJosn = SerializeJson();
            return countriesAsJosn;
        }

        private static string SerializeJson()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            string serializedJson = JsonConvert
                .SerializeObject(countries, Formatting.Indented, settings);

            return serializedJson;


        }

        private static List<Country> DeserializeJson(string responseAsString)
            => JsonConvert.DeserializeObject<List<Country>>(responseAsString);

        private static string ReadResponseAsStringAsync(Task<HttpResponseMessage> response)
        {
            return response.Result.Content.ReadAsStringAsync().Result;
        }

        private static Task<HttpResponseMessage> GetResponse(string api, string userIntput)
        {
            if (!api.EndsWith('/'))
            {
                api += '/';
            }
            string url = $"{api}{userIntput}";

            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> response = client.GetAsync(url);
            return response;

        }

        internal static string GetCsv()
        {
            using StringWriter writer = new StringWriter();

            CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture);
            csv.WriteField("name/common");
            csv.WriteField("name/official");
            csv.WriteField("region");
            csv.WriteField("subregion");
            csv.WriteField("capital");

            csv.NextRecord();

            foreach (var country in countries)
            {
                {
                    var countryCommonName = country.Name.Common == null
                        ? string.Empty
                        : country.Name.Common;
                    csv.WriteField(countryCommonName);
                }

                {
                    var countryOfficailName = country.Name.Official == null
                        ? string.Empty
                        : country.Name.Official;
                    csv.WriteField(countryOfficailName);
                }

                {
                    var region = country.Region == null
                        ? string.Empty
                        : country.Region;
                    csv.WriteField(region);
                }

                {
                    var subregion = country.Subregion == null
                        ? string.Empty
                        : country.Subregion;
                    csv.WriteField(subregion);
                }

                {
                    var capital = country.Capital == null
                        ? string.Empty
                        : string.Join(", ", country.Capital);
                    csv.WriteField(capital);
                }

                csv.NextRecord();
            }

            return writer.ToString();
        }
    }
}
