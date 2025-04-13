using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config;

public class ForumConfig : IEntityTypeConfiguration<Forum>
{
    public void Configure(EntityTypeBuilder<Forum> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Header).IsRequired();
        builder.Property(c => c.ForumGroupId).IsRequired();
        builder
        .HasOne(f => f.ForumGroup)
        .WithMany(fg => fg.Forums)
        .HasForeignKey(fg => fg.ForumGroupId);

        var forums = new List<Forum>()
        {
            new (1,"Hata Raporlama",1,"/images/icons/icon_report.png"),
            new (2,"Şikayet",1,"/images/icons/icon_complaint.png"),

            new (3,"Konu-Dışı",2),
            new (4,"Çöp",2),

            new (5,"Source Sunucuları (SRCDS)",3,"/images/icons/icon_server.png"),
            new (6,"HL1 Sunucuları (HLDS)",3,"/images/icons/icon_server.png"),

            new (7,"Haberler",4,"/images/icons/icon_news.png"),
            new (8,"Genel",4,"/images/icons/icon_general.png"),
            new (9,"Eklentiler",4,"/images/icons/icon_plugin.png"),
            new (10,"Kodlama",4,"/images/icons/icon_scripting.png"),

            new (11,"Haberler",5,"/images/icons/icon_news.png"),
            new (12,"Genel",5,"/images/icons/icon_general.png"),
            new (13,"Modlar",5,"/images/icons/icon_mod.png"),
            new (14,"Kodlama",5,"/images/icons/icon_scripting.png"),
        };

        builder.HasData(forums);
    }
}
