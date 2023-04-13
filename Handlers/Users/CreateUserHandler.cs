using MediatR;
using SampleMediatR.Commands.Users;
using SampleMediatR.Entity;
using SampleMediatR.Repository.Users;

namespace SampleMediatR.Handlers.Users
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand,User>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                Address = request.Address,

            };

           return await _userRepository.CreateUserAsync(user);
        }
    }
}
