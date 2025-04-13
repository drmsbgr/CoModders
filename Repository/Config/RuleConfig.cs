using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config;

public class RuleConfig : IEntityTypeConfiguration<Rule>
{
    public void Configure(EntityTypeBuilder<Rule> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Title).IsRequired();
        builder.Property(p => p.Description).IsRequired();

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
            new (9,"Tek Hesap Kullanın","Forumda sadece bir kullanıcı hesabınız olsun. Çoklu hesaplar yasaktır."),
            new (10,"Yönetici Uyarılarına Uyulmalı","Yöneticiler ve moderatörlerin uyarılarına uymayan kullanıcıların hesapları kısıtlanabilir."),
        };

        builder.HasData(rules);
    }
}