using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Domain.Entities;

namespace MyBlog.Inftastructure.Persistance.EntityTypeConfiguration
{
    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.PostId);

            builder.Property(x => x.Title)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
