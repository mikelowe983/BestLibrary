using BestLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestLibrary.Tests
{
    [TestClass]
    public class JsonServiceTests
    {
        class TestClass
        {
            public int Count { get; set; }
            public string Type { get; set; }
            public double Cost { get; set; }

            public override bool Equals(object obj)
            {
                if(obj is TestClass other)
                {
                    return other.Count == Count && other.Type == Type && other.Cost == Cost;
                }
                return false;
            }
        }

        [TestMethod]
        public void JsonService_CanSerialize()
        {
            var test = new TestClass
            {
                Cost = 45.3,
                Count = 42,
                Type = "Flange"
            };

            var json = JsonService.Serialize(test);

            var expectedJson = "{\"Count\":42,\"Type\":\"Flange\",\"Cost\":45.3}";

            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        public void JsonService_CanDeserialize()
        {
            var json = "{\"Count\":5,\"Type\":\"Thingie\",\"Cost\":88.5}";
            var expectedClass = new TestClass
            {
                Cost = 88.5,
                Count = 5,
                Type = "Thingie"
            };

            var val = JsonService.Deserialize<TestClass>(json);            

            Assert.AreEqual(expectedClass, val);            
        }

        [TestMethod]
        public void JsonService_CanReserialize()
        {
            var json = "{\"Count\":21,\"Type\":\"Connector\",\"Cost\":22.5}";
            var test = new TestClass
            {
                Cost = 22.50,
                Count = 21,
                Type = "Connector"
            };

            var val = JsonService.ReSerialize(test);

            Assert.AreEqual(test, val);
        }
    }
}
