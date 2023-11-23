using MediatR;
using Microsoft.EntityFrameworkCore;
using MyBlog.Application.Abstration;
using MyBlog.Application.UseCases.Post.Models;

namespace MyBlog.Application.UseCases.Post.Queries
{
    public class GetPostsQuery : IRequest<List<PostDto>>
    {

    }

    public class GetPostsQueryHandler : IRequestHandler<GetPostsQuery, List<PostDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetPostsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PostDto>> Handle(GetPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await    _context.Posts.Select(x => new PostDto()
            {
                PostId = x.PostId,
                Content = x.Content,
                Title = x.Title,
            }).ToListAsync(cancellationToken);

            return posts;
        }
    }
}
