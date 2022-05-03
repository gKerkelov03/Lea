﻿using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Commands.Core.Students;

public class GetAllUpcomingExamsForAStudentCommand : IRequest<GetAllUpcomingExamsForAStudentResponse>
{
}