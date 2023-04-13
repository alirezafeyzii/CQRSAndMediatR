using MediatR;
using SampleMediatR.Commands.Users;
using SampleMediatR.Repository.Users;

namespace SampleMediatR.Handlers.Users
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand,bool>
    {
        private readonly IUserRepository _userRepository;
        public UpdateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.Id);
            if (user == null)
                return false;

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.Address = request.Address;

            await _userRepository.UpdateUserAsync(user);
            return true;
        }
    }
}
