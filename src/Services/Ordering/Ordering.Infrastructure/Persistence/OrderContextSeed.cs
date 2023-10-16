using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetData());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetData()
        {
            return new List<Order>
            {
                new Order {
                    UserName = "swn",
                    FirstName = "Emre",
                    LastName = "Yelaldı",
                    EmailAddress = "emreyelaldi09@gmail.com",
                    AddressLine = "Istanbul",
                    Country = "Turkey",
                    TotalPrice = 350
                }
            };
        }
    }
}
