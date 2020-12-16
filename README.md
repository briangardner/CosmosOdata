# Documents $expand not working w/ OData

## Steps to Reproduce
1. Setup Cosmos DB Emulator, and create a database called `test`.
1. Create a collection called `TestEntities`.
1. Add a document like the following:
```
{   
    "PartitionKey": "abc123",
    "Name": "Test",
    "SomethingElse": "asdfkjasdljkf",
    "TestSubEntities": [
        {
            "Id": "blahblah",
            "Name": "name"
        }
    ]
}
```
1. Update Connection String in App Settings w/ connection string 
1. Run the application.
1. Using Postman, https://localhost:5001/odata/TestEntities?$expand=TestSubEntities (update root url accordingly).  This should produce results.
1. Go to TestEntityController, uncomment line 24, and comment out line 25.  Repeat previous step.