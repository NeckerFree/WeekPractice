using Newtonsoft.Json;
using System.Globalization;
using System.IO;

namespace AlgorithmsApp.GlossGenius
{
    public class CountSlots
    {
        private string jsonPath;
        public CountSlots(string jsonPath)
        {

            this.jsonPath = jsonPath;
        }

        public int CalculateSlot(int minutes)
        {
            int slot = 0;

            //deserialize JSON from file  
            // string jsonString = System.IO.File.ReadAllText(jsonPath);
            //var jsonReader = new JsonTextReader(new StringReader(jsonPath))
            //{
            //    SupportMultipleContent = true // This!!!
            //};

            //List<Item> items = new List<Item>();

            //var jsonReader = new JsonReader(new StringReader(jsonPath));
            //{
            //    SupportMultipleContent = true // This!!!
            //};

            //var jsonSerializer = new JsonSerializer();
            //while (jsonReader.Read())
            //{
            //    var obj = jsonReader;
            //    //Item item = jsonSerializer.Deserialize<Item>(jsonReader);
            //    //items.Add(item);
            //}
            //return items;

            //using StreamReader reader = new(jsonPath);
            //var json = reader.ReadToEnd();
            string dateString, format;
            DateTime result;
            CultureInfo provider = CultureInfo.InvariantCulture;

            // Parse date-only value with invariant culture.
            dateString = "8:30 AM";
            format = "t";
            result = DateTime.ParseExact(dateString, format, provider);
           string time = "8:30 AM";
           DateTime test= DateTime.Parse(time);
            string jsonString = File.ReadAllText(jsonPath);
            //var dynamicObject = JsonSerializer.Deserialize<dynamic>(openStream)!;
            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonString)!;
            //slot = dynamicObject.AsE
            return slot;

            
        }
        //static IEnumerable<SomeType> ReadFrom(string file)
        //{
        //    string line;
        //    using (var reader = File.OpenText(file))
        //    {
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            SomeType newRecord = /* parse line */
        //            yield return newRecord;
        //        }
        //    }
        //}
        public static (string? Genre, double Imdb, double Rotten) UsingDynamic(string jsonString)
        {
            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonString)!;
            var genre = dynamicObject.Genre;
            var imdb = dynamicObject.Rating.Imdb;
            var rotten = dynamicObject.Rating["Rotten Tomatoes"];
            return (genre, imdb, rotten);
        }
    }
}
