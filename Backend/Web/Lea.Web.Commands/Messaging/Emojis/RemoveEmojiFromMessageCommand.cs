﻿using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Commands.Messaging.Emojis;

public class RemoveEmojiFromMessageCommand : IRequest<RemoveEmojiFromMessageResponse>
{
}