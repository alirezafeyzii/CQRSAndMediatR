using MediatR;
using SampleMediatR.Entity;

namespace SampleMediatR.Queries.Users
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public Guid Id { get; set; }
    }
}
