using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            AppDbContext context = serviceProvider
                .GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            if(!context.Areas.Any())
            {
                context.Areas.AddRange(
                    new Area
                    {
                        AreaName = "DummyArea1",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0                  
                    },
                    new Area
                    {
                        AreaName = "DummyArea2",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    }
                );
            }
            context.SaveChanges();
        }
    }
}
