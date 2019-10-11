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
        public void JsonService_WillFail()
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
            Assert.Fail();
        }
    }
}
