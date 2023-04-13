using MediatR;
using SampleMediatR.Commands.Users;
using SampleMediatR.Repository.Users;

namespace SampleMediatR.Handlers.Users
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.Id);
            if (user == null)
                return false;

            await _userRepository.DeleteUserAsync(user.Id);
            return true;
        }
    }
}
