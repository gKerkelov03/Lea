﻿using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class GetAllLectorsHandler : IRequestHandler<GetAllLectorsForAGroupCommand, GetAllLectorsForAGroupResponse>
{
    private readonly ILectorsService groupsService;

    public GetAllLectorsHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllLectorsForAGroupResponse> Handle(GetAllLectorsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}