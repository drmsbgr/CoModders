using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config;

public class ThreadConfig : IEntityTypeConfiguration<Entities.Thread>
{
    public void Configure(EntityTypeBuilder<Entities.Thread> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Header).IsRequired();
        builder.Property(c => c.ForumId).IsRequired();
        builder
        .HasOne(t => t.Forum)
        .WithMany(f => f.Threads)
        .HasForeignKey(t => t.ForumId);

        var threads = new List<Entities.Thread>()
        {
            new (1,"Birinci şikayet konusu","Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus hic ducimus soluta dolorum maiores debitis rerum ut error! Magnam voluptate, excepturi odit laborum natus ad vero sequi tempore. Architecto voluptate perferendis magnam nulla perspiciatis. Tempora quisquam, autem quaerat voluptatum sit, eveniet atque quis tenetur exercitationem voluptatem vero voluptatibus, illo est.",2),
            new (2,"İkinci şikayet konusu","bu şikayet cart curt",2),
            new (3,"forumlardaki gönderilerin gözükmeme sorunu","kanser etti bu sorun beni, lütfen çözer misiniz?",1),
            new (4,"GTA 6 ne kadar gerçekçi bir oyun olacak?","Herkesin dilinde şuan, siz ne düşünüyorsunuz?",3)
        };

        builder.HasData(threads);
    }
}
