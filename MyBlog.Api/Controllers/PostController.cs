using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Application.UseCases.Post.Commands;
using MyBlog.Application.UseCases.Post.Queries;

namespace MyBlog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreatePostAsync(CreatePostCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res =  await _mediator.Send(new GetPostsQuery());

            return Ok(res);
        }
    }
}
