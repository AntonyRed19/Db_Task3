using System;
using System.Threading.Tasks;
using EFCoreDemo;
using Task3.Services;

namespace Task3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new Linq(context).Task();
            }

            Console.Read();
        }
    }
}
