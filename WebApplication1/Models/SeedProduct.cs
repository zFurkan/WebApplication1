using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class SeedProduct
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Products.Any())
                {
                    context.Products.AddRange(


                        new Product() { Name = "T1", Description = "Siyah", Category = "Benzin", Price = 100000 },
                        new Product() { Name = "X10", Description = "Beyaz", Category = "Dizel", Price = 150000 },
                        new Product() { Name = "AB1", Description = "Beyaz", Category = "Dizel", Price = 95000 }

                    );
                    context.SaveChanges();
                }

            }
        }
    }
}

