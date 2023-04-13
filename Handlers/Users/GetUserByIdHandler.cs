using MediatR;
using SampleMediatR.Entity;
using SampleMediatR.Queries.Users;
using SampleMediatR.Repository.Users;

namespace SampleMediatR.Handlers.Users
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
           return await _userRepository.GetUserByIdAsync(request.Id);
        }
    }
}
