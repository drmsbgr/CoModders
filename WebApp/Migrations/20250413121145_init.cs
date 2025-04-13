using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "Text" },
                values: new object[,]
                {
                    { 1, "Mod sayfasında yer alan \"İndir\" butonuna tıklayarak dosyayı cihazınıza indirebilirsiniz. Giriş yapmanız gerekebilir.", "Modları nasıl indirebilirim?" },
                    { 2, "Her modun altında, kurulum adımları ayrı bir başlık altında açıklanır. Genel olarak, indirdiğiniz dosyayı oyunun kurulu olduğu klasöre kopyalamanız yeterlidir.", "Modu oyuna nasıl kurabilirim?" },
                    { 3, "Öncelikle modun oyununuzun sürümüyle uyumlu olup olmadığını kontrol edin. Yine de sorun yaşarsanız ilgili mod başlığında yardım isteyebilirsiniz.", "Bir mod çalışmıyor, ne yapmalıyım?" },
                    { 4, "\"Mod Paylaş\" bölümüne giderek yeni konu açabilir ve modunuzu dosya olarak ekleyebilirsiniz. Açıklama, kurulum bilgisi ve ekran görüntüsü eklemeniz önerilir.", "Kendi yaptığım modu nasıl paylaşabilirim?" },
                    { 5, "Telif hakkı ihlali içermeyen, sizin tarafınızdan yapılmış ya da izinle paylaşılan modlar paylaşılabilir. Aksi durumda moderatörler içeriği kaldırabilir.", "Mod paylaşmak yasak mı? Telif sorunları olur mu?" }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Tüm üyelerle nazik ve saygılı bir şekilde iletişim kurun. Hakaret, küfür, alaycı tavırlar yasaktır.", "Saygılı Olun" },
                    { 2, "Her konuyu doğru kategoriye açın. Konu dışı mesajlar silinebilir veya taşınabilir.", "Konu Dışı Paylaşım Yapmayın" },
                    { 3, "Yeni bir konu açmadan önce forumda benzer bir konu olup olmadığını kontrol edin.", "Spam ve Reklam Yasaktır" },
                    { 4, "Yeni bir konu açmadan önce forumda benzer bir konu olup olmadığını kontrol edin.", "Arama Yapmadan Konu Açmayın" },
                    { 5, "Paylaşımlarınızda telif hakkı ihlali, yasa dışı içerik veya suç teşkil eden ifadeler bulundurmayın.", "Yasalara Uyun" },
                    { 6, "Forum ortamında küfür, argo, tehdit veya hakaret içeren ifadeler kullanmayın.", "Küfür ve Hakaret Etmeyin" },
                    { 7, "Kendi veya başkasına ait özel bilgileri (adres, telefon, şifre vb.) paylaşmayın.", "Kişisel Bilgi Paylaşmayın" },
                    { 8, "Fikir ayrılıkları doğaldır. Tartışmaları kişiselleştirmeyin, yapıcı olun.", "Tartışmalarda Soğukkanlı Kalın" },
                    { 9, "Forumda sadece bir kullanıcı hesabınız olsun. Çoklu hesaplar yasaktır.", "Tartışmalarda Soğukkanlı Kalın" },
                    { 10, "Yöneticiler ve moderatörlerin uyarılarına uymayan kullanıcıların hesapları kısıtlanabilir.", "Yönetici Uyarılarına Uyulmalı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Rules");
        }
    }
}
