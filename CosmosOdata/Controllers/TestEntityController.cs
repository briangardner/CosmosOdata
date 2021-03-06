﻿using System.Linq;
using CosmosOdata.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;

namespace CosmosOdata.Controllers
{

    public class TestEntityController : ODataController
    {
        private readonly CosmosDbContext _context;

        public TestEntityController(CosmosDbContext context)
        {
            _context = context;
        }

        [ODataRoute("/TestEntities")]
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<TestEntity>> Get()
        {

            //return Ok(_context.TestEntities);// -- this does not work
            return Ok(_context.TestEntities.ToList().AsQueryable());
        }
    }
}
