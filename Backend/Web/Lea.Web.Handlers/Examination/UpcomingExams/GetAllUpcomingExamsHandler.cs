﻿using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Examination.UpcomingExams;

public class GetAllUpcomingExamsHandler : IRequestHandler<GetAllUpcomingExamsForAGroupCommand, GetAllUpcomingExamsForAGroupResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public GetAllUpcomingExamsHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<GetAllUpcomingExamsForAGroupResponse> Handle(GetAllUpcomingExamsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}