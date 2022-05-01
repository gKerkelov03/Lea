﻿using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Commands.Messaging.Channels;

public class GetAllChannelsCommand : IRequest<GetAllChannelsResponse>
{
}