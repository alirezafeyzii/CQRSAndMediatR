using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleMediatR.Commands.Users;
using SampleMediatR.Entity;
using SampleMediatR.Models.Responses.Users;
using SampleMediatR.Queries.Users;

namespace SampleMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserController(IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<UserResponse>> GetAllUsersAsync()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());
            return _mapper.Map<List<UserResponse>>(users);
        }

        [HttpGet("UserId")]
        public async Task<UserResponse> GetUserById(Guid id)
        {
            var user = await _mediator.Send(new GetUserByIdQuery() { Id = id });
            return _mapper.Map<UserResponse>(user);
        }

        [HttpPost]
        public async Task<UserResponse> CreateUserAsync(User user)
        {
            var creatdUser = await _mediator.Send(new CreateUserCommand(
                user.FirstName,
                user.LastName,
                user.Email,
                user.Password,
                user.Address));

            return _mapper.Map<UserResponse>(creatdUser);
        }

        [HttpPut]
        public async Task<bool> UpdateUserAsync(User user)
        {
            return await _mediator.Send(new UpdateUserCommand(
                user.Id,
                user.FirstName,
                user.LastName,
                user.Email,
                user.Password,
                user.Address));
        }

        [HttpDelete]
        public async Task<bool> DeleteUserByIdAsync(Guid id)
        {
            return await _mediator.Send(new DeleteUserCommand() { Id = id});
        }
    }
}
