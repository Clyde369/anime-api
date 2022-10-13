using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animeapi.Server.Migrations
{
    public partial class WeaponAndCharacterSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Characters");

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "Description", "ImageUrl", "Name", "Tier", "Weapon", "WeaponImgUrl" },
                values: new object[,]
                {
                    { 1, 17, "Ichigo Kurosaki (Japanese: 黒崎 一護, Hepburn: Kurosaki Ichigo) is a fictional character in the Bleach manga series and its adaptations created by Tite Kubo. He is the main protagonist of the series, who receives Soul Reaper powers after meeting Rukia Kuchiki, a Soul Reaper assigned to patrol around the fictional city of Karakura Town. These powers come at the cost of her own, and as a result, he concedes to work as her stand-in, fighting to protect people from evil spirits called Hollows and sending good spirits, wholes, to a dimension known as the Soul Society. Ichigo appears in other media after the manga series, including the anime television series, four anime films, two original video animations, rock musicals, several video games, light novels and the 2018 live-action film.", "https://images4.alphacoders.com/295/thumbbig-295218.webp", "Ichigo Kurosaki", 5, "Zangetsu", "https://cdn11.bigcommerce.com/s-cykw02w8qi/images/stencil/1280x1280/products/8780/11530/1251183232773__99896__69563.1628110515.jpg?c=1" },
                    { 2, 15, "Gintoki Sakata (坂田 銀時, Sakata Gintoki) is the main protagonist of the action comedy anime and manga series, Gintama. While usually coming across as lazy, selfish, greedy, and an overall jerk, he is a true hero who defends those who cannot fight for themselves and always keeps his promises to protect others and especially those close to him. He is a jack of all trades who runs his own business called the Yorozuya, who take on all manners of jobs for a small fee. He runs this business alongside his two friends, a young samurai-in-training Shimura Shinpachi and the young alien girl Kagura.", "https://images5.alphacoders.com/677/thumbbig-677361.webp", "Gintoki Sakata", 5, "butter knife", "https://cdn11.bigcommerce.com/s-cykw02w8qi/images/stencil/1280x1280/products/8780/11530/1251183232773__99896__69563.1628110515.jpg?c=1" },
                    { 3, 12, "Ken Kaneki (金カネ木キ 研ケン, Kaneki Ken) is the main protagonist of the Tokyo Ghoul series. He is currently Touka Kirishima's husband, and the father of Ichika Kaneki. Previously, he was a student who studied Japanese literature at Kamii University, living a relatively normal life. However, this quickly changed after Rize Kamishiro's kakuhou was transplanted into him and transformed him into a one-eyed ghoul. Kaneki is the first known artificial one-eyed ghoul. His unique half ghoul state is what later inspires the idea of the Quinx. After joining Anteiku as a part-time waiter, he learns how to live as a ghoul and eventually becomes known as Eyepatch (眼帯, Gantai).", "https://static.wikia.nocookie.net/tokyoghoul/images/7/7d/Kaneki_Finale_HQ.png/revision/latest?cb=20180706042331", "Ken Kaneki", 3, "sharper butter knife", "https://cdn11.bigcommerce.com/s-cykw02w8qi/images/stencil/1280x1280/products/8780/11530/1251183232773__99896__69563.1628110515.jpg?c=1" }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 2, "dogshit", "dogshit" },
                    { 3, "dogshit", "dogshit1" },
                    { 5, "dogshit", "dogshit2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
