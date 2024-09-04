using Business.Data;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class StaticParamLogic
    {
        private readonly MangoProductAPIContext context;

        public StaticParamLogic(DbContextOptions<MangoProductAPIContext> options)
        {
            context = new MangoProductAPIContext(options);
        }

        public StaticParam? GetParamById(string key)
        {            
            var staticParam = context.StaticParams.FirstOrDefault(p => p.Key == key);

            return staticParam;
        }
    }
}
