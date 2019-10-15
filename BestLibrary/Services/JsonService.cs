using System;
using Newtonsoft.Json;

namespace BestLibrary.Services
{
    public class JsonService
    {
        /// <summary>
        /// Serializes an object to a JSON string
        /// </summary>
        /// <param name="toSerialize">The Object to serialize</param>
        /// <returns>A serialized JSON string representation of the object</returns>
        public static string Serialize(object toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize);
        }

        /// <summary>
        /// Desrializes a JSON string to an object
        /// </summary>
        /// <typeparam name="T">The desired output type</typeparam>
        /// <param name="json">The JSON input string</param>
        /// <returns>The deserialized object</returns>
        public static T Deserialize<T>(string json)
        {            
            return JsonConvert.DeserializeObject<T>(json);
        }


        /// <summary>
        /// Serializes an object to JSON then Desrializes that JSON string to an object
        /// </summary>
        /// <typeparam name="T">The desired output type</typeparam>
        /// <param name="toSerialize">The Object to serialize</param>
        /// <returns>The deserialized object</returns>
        public static T ReSerialize<T>(T toSerialize)
        {
            return Deserialize<T>(Serialize(toSerialize));
        }
    }
}
