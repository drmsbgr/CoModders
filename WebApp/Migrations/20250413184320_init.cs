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
                name: "ForumGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Header = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
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
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IconUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Header = table.Column<string>(type: "TEXT", nullable: false),
                    ForumGroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forums_ForumGroups_ForumGroupId",
                        column: x => x.ForumGroupId,
                        principalTable: "ForumGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Header = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    ForumId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Threads_Forums_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Header = table.Column<string>(type: "TEXT", nullable: false),
                    ThreadId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ForumGroups",
                columns: new[] { "Id", "Header" },
                values: new object[,]
                {
                    { 1, "Sistemler" },
                    { 2, "Diğer" },
                    { 3, "Sunucu Tartışmaları" },
                    { 4, "AMX Mod X" },
                    { 5, "Minecraft" }
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
                    { 9, "Forumda sadece bir kullanıcı hesabınız olsun. Çoklu hesaplar yasaktır.", "Tek Hesap Kullanın" },
                    { 10, "Yöneticiler ve moderatörlerin uyarılarına uymayan kullanıcıların hesapları kısıtlanabilir.", "Yönetici Uyarılarına Uyulmalı" }
                });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "ForumGroupId", "Header", "IconUrl" },
                values: new object[,]
                {
                    { 1, 1, "Hata Raporlama", "/images/icons/icon_report.png" },
                    { 2, 1, "Şikayet", "/images/icons/icon_complaint.png" },
                    { 3, 2, "Konu-Dışı", "" },
                    { 4, 2, "Çöp", "" },
                    { 5, 3, "Source Sunucuları (SRCDS)", "/images/icons/icon_server.png" },
                    { 6, 3, "HL1 Sunucuları (HLDS)", "/images/icons/icon_server.png" },
                    { 7, 4, "Haberler", "/images/icons/icon_news.png" },
                    { 8, 4, "Genel", "/images/icons/icon_general.png" },
                    { 9, 4, "Eklentiler", "/images/icons/icon_plugin.png" },
                    { 10, 4, "Kodlama", "/images/icons/icon_scripting.png" },
                    { 11, 5, "Haberler", "/images/icons/icon_news.png" },
                    { 12, 5, "Genel", "/images/icons/icon_general.png" },
                    { 13, 5, "Modlar", "/images/icons/icon_mod.png" },
                    { 14, 5, "Kodlama", "/images/icons/icon_scripting.png" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "ForumId", "Header", "Text" },
                values: new object[,]
                {
                    { 1, 2, "Birinci şikayet konusu", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus hic ducimus soluta dolorum maiores debitis rerum ut error! Magnam voluptate, excepturi odit laborum natus ad vero sequi tempore. Architecto voluptate perferendis magnam nulla perspiciatis. Tempora quisquam, autem quaerat voluptatum sit, eveniet atque quis tenetur exercitationem voluptatem vero voluptatibus, illo est." },
                    { 2, 2, "İkinci şikayet konusu", "bu şikayet cart curt" },
                    { 3, 1, "forumlardaki gönderilerin gözükmeme sorunu", "kanser etti bu sorun beni, lütfen çözer misiniz?" },
                    { 4, 3, "GTA 6 ne kadar gerçekçi bir oyun olacak?", "Herkesin dilinde şuan, siz ne düşünüyorsunuz?" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Header", "ThreadId" },
                values: new object[,]
                {
                    { 1, "o sorun çözüldü sanırım ya.", 3 },
                    { 2, "ister olsun ister olmasın para var mı ki oynayabilecez.", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumGroupId",
                table: "Forums",
                column: "ForumGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ThreadId",
                table: "Posts",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_ForumId",
                table: "Threads",
                column: "ForumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "ForumGroups");
        }
    }
}
