using MediatR;
using SampleMediatR.Entity;

namespace SampleMediatR.Queries.Users
{
    public class GetAllUsersQuery : IRequest<List<User>>
    {
    }
}
