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
            throw new Exception("OUCH"!);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T ReSerialize<T>(T toSerialize)
        {
            return Deserialize<T>(Serialize(toSerialize));
        }
    }
}
