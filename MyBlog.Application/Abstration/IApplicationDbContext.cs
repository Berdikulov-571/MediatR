using Microsoft.EntityFrameworkCore;
using MyBlog.Domain.Entities;

namespace MyBlog.Application.Abstration
{
    public interface IApplicationDbContext
    {
        DbSet<Post> Posts { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
