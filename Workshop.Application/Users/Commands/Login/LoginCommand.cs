using MediatR;
using Workshop.Application.Users.Dtos;

namespace Workshop.Application.Users.Commands.Login;

public class LoginCommand : IRequest<LoginResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
}