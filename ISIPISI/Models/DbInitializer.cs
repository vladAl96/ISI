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
                        AreaName = "ARAD-PAULIS",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0                  
                    },
                    new Area
                    {
                        AreaName = "LIPOVA",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    },
                    new Area
                    {
                        AreaName = "USUSAU",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    },
                    new Area
                    {
                        AreaName = "LALASINT",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    },
                    new Area
                    {
                        AreaName = "BATA-BIRCHIS",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    },
                    new Area
                    {
                        AreaName = "BURJOC",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    },
                    new Area
                    {
                        AreaName = "DOBRA-ILIA",
                        PH = 0,
                        PollutionPercentage = 0,
                        NocSubsQTTY = 0
                    },
                    new Area
                    {
                        AreaName = "BRASNICA-DEVA",
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
