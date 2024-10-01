using Koi_Web_BE.Models.Primitives;
using Koi_Web_BE.UseCases.UC_Orders.Queries;
using MediatR;

namespace Koi_Web_BE.Endpoints.EndpointHandlers.Orders;

public class GetPersonalOrdersEndpointHandler
{
    public async static Task<IResult> Handle(ISender sender, int pageIndex = 1, int pageSize = 10, CancellationToken cancellationToken = default)
    {
        Result<GetPersonalOrders.Response> response = await sender
                    .Send(new GetPersonalOrders.Query(pageIndex, pageSize), cancellationToken);
        if (!response.Succeeded) return Results.NotFound(response);
        return Results.Ok(response);
    }
}