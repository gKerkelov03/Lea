using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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