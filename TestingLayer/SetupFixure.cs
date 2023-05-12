using NUnit.Framework;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace TestingLayer
{
    [SetUpFixture]
    static class SetupFixure
    {
        public static Test2DbContext dbContext;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            dbContext = new Test2DbContext(builder.Options);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            dbContext.Dispose();
        }
    }
}