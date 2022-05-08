using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Groups.ChangeBackgroundImage;

public class ChangeGroupBackgroundImageHandler : IRequestHandler<ChangeGroupBackgroundImageCommand, ChangeGroupBackgroundImageResponse>
{
    private readonly IGroupsService groupsService;

    public ChangeGroupBackgroundImageHandler(IGroupsService groupsService)
        => this.groupsService = groupsService;

    public Task<ChangeGroupBackgroundImageResponse> Handle(ChangeGroupBackgroundImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}