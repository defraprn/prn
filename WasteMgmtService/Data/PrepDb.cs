using System;
using WasteMgmtService.Models;

namespace WasteMgmtService.Data
{
    public static class PrepDb
    {
        public static void PrepPoulation(IApplicationBuilder app)
        {
            using (var ServiceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(ServiceScope.ServiceProvider.GetService<AppDbContext>());
            }

        }
        private static void SeedData(AppDbContext context)
        {
            if (!context.Wastes.Any())
            {
                Console.WriteLine("Seeding data");
                context.Wastes.AddRange(
                    new Waste() { WasteMaterial = "Plastic", WasteWeight = 10 },
                    new Waste() { WasteMaterial = "Paper", WasteWeight = 20 },
                    new Waste() { WasteMaterial = "Steel", WasteWeight = 30 });
                context.SaveChanges();
            }
        }
    }
}


