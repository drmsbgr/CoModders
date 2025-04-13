using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config;

public class ForumGroupConfig : IEntityTypeConfiguration<ForumGroup>
{
    public void Configure(EntityTypeBuilder<ForumGroup> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Header).IsRequired();
        builder
        .HasMany(fg => fg.Forums)
        .WithOne(f => f.ForumGroup)
        .HasForeignKey(f => f.ForumGroupId);

        var forumGroups = new List<ForumGroup>()
        {
            new (1,"Sistemler"),
            new (2,"Diğer"),
            new (3,"Sunucu Tartışmaları"),
            new (4,"AMX Mod X"),
            new (5,"Minecraft")
        };

        builder.HasData(forumGroups);
    }
}
