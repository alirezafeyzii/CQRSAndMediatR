using SampleMediatR.Entity;

namespace SampleMediatR.Repository.Users
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsersAsync();
        public Task<User> GetUserByIdAsync(Guid Id);
        public Task<User> CreateUserAsync(User user);
        public Task<bool> UpdateUserAsync(User user);
        public Task<bool> DeleteUserAsync(Guid Id);
    }
}
