using MediatR;

namespace SampleMediatR.Commands.Users
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
