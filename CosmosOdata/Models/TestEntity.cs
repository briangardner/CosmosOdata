using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CosmosOdata.Models
{
    public class TestEntity
    {
        public TestEntity()
        {
            TestSubEntities = new List<TestSubEntity>();
        }
        public string PartitionKey { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string SomethingElse { get; set; }
        public ICollection<TestSubEntity> TestSubEntities { get; set; }
    }

    public class TestSubEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
