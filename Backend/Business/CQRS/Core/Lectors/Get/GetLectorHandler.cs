using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Lectors.Get;

public class GetLectorHandler : IRequestHandler<GetLectorCommand, GetLectorResponse>
{
    private readonly ILectorsService groupsService;

    public GetLectorHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetLectorResponse> Handle(GetLectorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}