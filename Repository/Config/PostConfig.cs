using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config;

public class PostConfig : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Header).IsRequired();
        builder.Property(p => p.ThreadId).IsRequired();
        builder
        .HasOne(p => p.Thread)
        .WithMany(t => t.Posts)
        .HasForeignKey(p => p.ThreadId);

        var posts = new List<Post>()
        {
            new (1,"o sorun çözüldü sanırım ya.",3),
            new (2,"ister olsun ister olmasın para var mı ki oynayabilecez.",4)
        };

        builder.HasData(posts);
    }
}
