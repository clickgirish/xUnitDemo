using Business.Data;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class StaticParamLogic
    {
        public StaticParam? GetParamById(string key)
        {
            MangoProductAPIContext context = new MangoProductAPIContext();
            var staticParam = context.StaticParams.FirstOrDefault(p => p.Key == key);

            return staticParam;
        }
    }
}
