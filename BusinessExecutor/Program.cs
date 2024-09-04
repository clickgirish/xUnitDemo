using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessExecutor
{
    public static class Program
    {
        static void Main()
        {
            StaticParamLogic logic = new StaticParamLogic();
            var staticParam = logic.GetParamById("Param1");

            if (staticParam != null)
                Console.WriteLine(staticParam.Value);
            else
                Console.WriteLine(" Static Param not found");

            Console.ReadLine();
        }
    }
}
