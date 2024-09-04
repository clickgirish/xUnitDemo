using Business.Data;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

public static class TestDbContextFactory
{
    public static MangoProductAPIContext Create()
    {
        var options = new DbContextOptionsBuilder<MangoProductAPIContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDb")
            .Options;

        var context = new MangoProductAPIContext(options);

        // Seed test data if necessary
        SeedTestData(context);

        return context;
    }

    private static void SeedTestData(MangoProductAPIContext context)
    {
        // Check if the table already contains data to prevent seeding multiple times
        if (!context.StaticParam.Any())
        {
            context.StaticParam.AddRange(
                new StaticParam
                {
                    Key = "Param1",
                    Value = "Value1",
                    Description = "This is the first parameter"
                },
                new StaticParam
                {
                    Key = "Param2",
                    Value = "Value2",
                    Description = "This is the second parameter"
                },
                new StaticParam
                {
                    Key = "Param3",
                    Value = "Value3",
                    Description = "This is the third parameter"
                },
                new StaticParam
                {
                    Key = "Param4",
                    Value = "Value4",
                    Description = "This is the fourth parameter"
                },
                new StaticParam
                {
                    Key = "Param5",
                    Value = "Value5",
                    Description = "This is the fifth parameter"
                }
            );

            // Save changes to the in-memory database
            context.SaveChanges();
        }
    }

}
