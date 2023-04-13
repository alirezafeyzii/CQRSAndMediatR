using MediatR;
using SampleMediatR.Entity;

namespace SampleMediatR.Commands.Users
{
    public class UpdateUserCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public UpdateUserCommand(
            Guid id,
            string firstName,
            string lastName,
            string email,
            string password,
            string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Address = address;
        }
    }
}
