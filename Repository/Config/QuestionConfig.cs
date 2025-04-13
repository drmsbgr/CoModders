using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config;

public class QuestionConfig : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Text).IsRequired();
        builder.Property(c => c.Description).IsRequired();
        var questions = new List<Question>()
        {
            new(1,"Modları nasıl indirebilirim?","Mod sayfasında yer alan \"İndir\" butonuna tıklayarak dosyayı cihazınıza indirebilirsiniz. Giriş yapmanız gerekebilir."),
            new(2,"Modu oyuna nasıl kurabilirim?","Her modun altında, kurulum adımları ayrı bir başlık altında açıklanır. Genel olarak, indirdiğiniz dosyayı oyunun kurulu olduğu klasöre kopyalamanız yeterlidir."),
            new(3,"Bir mod çalışmıyor, ne yapmalıyım?","Öncelikle modun oyununuzun sürümüyle uyumlu olup olmadığını kontrol edin. Yine de sorun yaşarsanız ilgili mod başlığında yardım isteyebilirsiniz."),
            new(4,"Kendi yaptığım modu nasıl paylaşabilirim?","\"Mod Paylaş\" bölümüne giderek yeni konu açabilir ve modunuzu dosya olarak ekleyebilirsiniz. Açıklama, kurulum bilgisi ve ekran görüntüsü eklemeniz önerilir."),
            new(5,"Mod paylaşmak yasak mı? Telif sorunları olur mu?","Telif hakkı ihlali içermeyen, sizin tarafınızdan yapılmış ya da izinle paylaşılan modlar paylaşılabilir. Aksi durumda moderatörler içeriği kaldırabilir."),
        };
        builder.HasData(questions);
    }
}
