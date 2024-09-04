using Business.Data;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class StaticParamLogic
    {
        private readonly MangoProductAPIContext context;

        public StaticParamLogic(MangoProductAPIContext context)
        {
            this.context = context;
        }

        public StaticParamLogic(DbContextOptions<MangoProductAPIContext> options)
        {
            context = new MangoProductAPIContext(options);
        }

        public StaticParam? GetParamById(string key)
        {
            var staticParam = context.StaticParams
                .AsNoTracking()  // Ensure the entity isn't tracked to prevent potential issues when working with keyless entities.
                .FirstOrDefault(p => p.Key == key);

            return staticParam;
        }
    }
}
