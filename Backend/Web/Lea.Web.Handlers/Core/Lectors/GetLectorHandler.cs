﻿using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

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