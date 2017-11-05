using System;
using System.Collections.Generic;
using System.Text;
using SpyStore2.Models.Entities;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SpyStore.DAL.EF;

namespace SpyStore.DAL.Tests.ContextTests
{
    [Collection("SpyStore.DAL")]
    public class CategoryTests :IDisposable
    {
        private readonly StoreContext _db;
        public CategoryTests()
        {
            _db = new StoreContext();
            CleanDatabase();
        }

        public void Dispose()
        {
            _db.Dispose();
            CleanDatabase();
        }

        private void CleanDatabase()
        {
            _db.Database.ExecuteSqlCommand("Delete from Store.Categories");
            _db.Database.ExecuteSqlCommand($"DBCC CHECKIDENT (\"Store.Categories\", RESEED, -1);");
        }

        [Fact]
        public void FirstTest()
        {
            Assert.True(true);
        }
    }
}
