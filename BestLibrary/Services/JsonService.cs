using System;
using Newtonsoft.Json;

namespace BestLibrary.Services
{
    public class JsonService
    {        
        public static string Serialize(object toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
