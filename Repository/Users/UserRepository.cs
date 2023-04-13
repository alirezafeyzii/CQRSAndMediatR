using Microsoft.EntityFrameworkCore;
using SampleMediatR.Data;
using SampleMediatR.Entity;

namespace SampleMediatR.Repository.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            var result = await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> DeleteUserAsync(Guid Id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == Id);
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid Id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
