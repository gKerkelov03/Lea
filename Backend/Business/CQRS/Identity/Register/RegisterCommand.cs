using MediatR;

namespace CQRS.Identity.Register;

public class RegisterCommand : IRequest<RegisterResponse>
{
}