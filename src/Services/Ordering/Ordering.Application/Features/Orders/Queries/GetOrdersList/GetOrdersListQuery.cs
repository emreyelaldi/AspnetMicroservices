using MediatR;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVM>>
    {
        public GetOrdersListQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }


    }
}
