﻿using Lea.Web.Responses.Messaging.Polls;
using MediatR;

namespace Lea.Web.Commands.Messaging.Polls;

public class GetAllPollsCommand : IRequest<GetAllPollsResponse>
{
}