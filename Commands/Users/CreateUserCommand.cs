using MediatR;
using SampleMediatR.Entity;

namespace SampleMediatR.Commands.Users
{
    public class CreateUserCommand : IRequest<User>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public CreateUserCommand(
            string firstName,
            string lastName,
            string email,
            string password,
            string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Address = address;
        }
    }
}
