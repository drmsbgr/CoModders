using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Rule> Rules { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<ForumGroup> ForumGroups { get; set; }
    public DbSet<Forum> Forums { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var rules = new List<Rule>()
        {
            new (1,"Saygılı Olun","Tüm üyelerle nazik ve saygılı bir şekilde iletişim kurun. Hakaret, küfür, alaycı tavırlar yasaktır."),
            new (2,"Konu Dışı Paylaşım Yapmayın","Her konuyu doğru kategoriye açın. Konu dışı mesajlar silinebilir veya taşınabilir."),
            new (3,"Spam ve Reklam Yasaktır","Yeni bir konu açmadan önce forumda benzer bir konu olup olmadığını kontrol edin."),
            new (4,"Arama Yapmadan Konu Açmayın","Yeni bir konu açmadan önce forumda benzer bir konu olup olmadığını kontrol edin."),
            new (5,"Yasalara Uyun","Paylaşımlarınızda telif hakkı ihlali, yasa dışı içerik veya suç teşkil eden ifadeler bulundurmayın."),
            new (6,"Küfür ve Hakaret Etmeyin","Forum ortamında küfür, argo, tehdit veya hakaret içeren ifadeler kullanmayın."),
            new (7,"Kişisel Bilgi Paylaşmayın","Kendi veya başkasına ait özel bilgileri (adres, telefon, şifre vb.) paylaşmayın."),
            new (8,"Tartışmalarda Soğukkanlı Kalın","Fikir ayrılıkları doğaldır. Tartışmaları kişiselleştirmeyin, yapıcı olun."),
            new (9,"Tartışmalarda Soğukkanlı Kalın","Forumda sadece bir kullanıcı hesabınız olsun. Çoklu hesaplar yasaktır."),
            new (10,"Yönetici Uyarılarına Uyulmalı","Yöneticiler ve moderatörlerin uyarılarına uymayan kullanıcıların hesapları kısıtlanabilir."),
        };
        modelBuilder.Entity<Rule>().HasData(rules);

        var questions = new List<Question>()
        {
            new(1,"Modları nasıl indirebilirim?","Mod sayfasında yer alan \"İndir\" butonuna tıklayarak dosyayı cihazınıza indirebilirsiniz. Giriş yapmanız gerekebilir."),
            new(2,"Modu oyuna nasıl kurabilirim?","Her modun altında, kurulum adımları ayrı bir başlık altında açıklanır. Genel olarak, indirdiğiniz dosyayı oyunun kurulu olduğu klasöre kopyalamanız yeterlidir."),
            new(3,"Bir mod çalışmıyor, ne yapmalıyım?","Öncelikle modun oyununuzun sürümüyle uyumlu olup olmadığını kontrol edin. Yine de sorun yaşarsanız ilgili mod başlığında yardım isteyebilirsiniz."),
            new(4,"Kendi yaptığım modu nasıl paylaşabilirim?","\"Mod Paylaş\" bölümüne giderek yeni konu açabilir ve modunuzu dosya olarak ekleyebilirsiniz. Açıklama, kurulum bilgisi ve ekran görüntüsü eklemeniz önerilir."),
            new(5,"Mod paylaşmak yasak mı? Telif sorunları olur mu?","Telif hakkı ihlali içermeyen, sizin tarafınızdan yapılmış ya da izinle paylaşılan modlar paylaşılabilir. Aksi durumda moderatörler içeriği kaldırabilir."),
        };

        modelBuilder.Entity<Question>().HasData(questions);
    }
}
