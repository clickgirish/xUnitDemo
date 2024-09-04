using Business.Data;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

public static class TestDbContextFactory
{
    public static MangoProductAPIContext Create()
    {
        var options = BuildContextOptions();
        var context = BuildContext(options);

        return context;
    }

    private static DbContextOptions<MangoProductAPIContext> BuildContextOptions()
    {
        var options = new DbContextOptionsBuilder<MangoProductAPIContext>()
           .UseInMemoryDatabase(databaseName: "InMemoryDb")
           .Options;

        return options;
    }

    private static MangoProductAPIContext BuildContext(DbContextOptions<MangoProductAPIContext> options)
    {
        var staticParams = new List<StaticParam>
        {
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
                }
        };

        var context = new MangoProductAPIContext(options, (context, modelBuilder) =>
        {
            modelBuilder.Entity<StaticParam>().ToInMemoryQuery(() => staticParams);
        });

        context.SaveChanges();

        return context;
    }
}
