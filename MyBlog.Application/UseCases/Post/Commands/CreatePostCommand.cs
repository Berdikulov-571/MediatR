using MediatR;
using MyBlog.Application.Abstration;

namespace MyBlog.Application.UseCases.Post.Commands
{
    public class CreatePostCommand : IRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class CreatePostHandlers : AsyncRequestHandler<CreatePostCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreatePostHandlers(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Domain.Entities.Post()
            {
                Title = request.Title,
                Content = request.Content,
            };

            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
