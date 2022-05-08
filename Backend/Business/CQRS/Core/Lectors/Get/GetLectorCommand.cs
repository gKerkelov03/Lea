using MediatR;

namespace CQRS.Core.Lectors.Get;

public class GetLectorCommand : IRequest<GetLectorResponse>
{
}