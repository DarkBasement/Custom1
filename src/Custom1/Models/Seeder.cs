using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom1.Models
{
    public static class Seeder
    {
        public static void Seed(IServiceProvider services)
        {
            ApplicationDbContext context = (ApplicationDbContext)services.GetService(typeof(ApplicationDbContext));
            if (context.Info.Any())
                return;

            context.Info.Add(new Info { Name = "my first information" });
            context.Info.Add(new Info { Name = "my second information" });
            context.Info.Add(new Info { Name = "someone information" });

            context.SaveChanges();
        }
    }
}
