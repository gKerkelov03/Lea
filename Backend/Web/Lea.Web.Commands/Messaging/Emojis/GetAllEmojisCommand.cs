﻿using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Commands.Messaging.Emojis;

public class GetAllEmojisCommand : IRequest<GetAllEmojisResponse>
{
}