using Microsoft.EntityFrameworkCore;

namespace animeapi.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Characters").HasData(
                     new Character
                     {
                         Id = 1,
                         Name = "Ichigo Kurosaki",
                         ImageUrl = "https://images4.alphacoders.com/295/thumbbig-295218.webp",
                         Tier = 5,
                         Description = "Ichigo Kurosaki (Japanese: 黒崎 一護, Hepburn: Kurosaki Ichigo) is a fictional character in the Bleach manga series and its adaptations created by Tite Kubo. He is the main protagonist of the series, who receives Soul Reaper powers after meeting Rukia Kuchiki, a Soul Reaper assigned to patrol around the fictional city of Karakura Town. These powers come at the cost of her own, and as a result, he concedes to work as her stand-in, fighting to protect people from evil spirits called Hollows and sending good spirits, wholes, to a dimension known as the Soul Society. Ichigo appears in other media after the manga series, including the anime television series, four anime films, two original video animations, rock musicals, several video games, light novels and the 2018 live-action film.",
                         Weapon = "Zangetsu",
                         WeaponImgUrl = "https://cdn11.bigcommerce.com/s-cykw02w8qi/images/stencil/1280x1280/products/8780/11530/1251183232773__99896__69563.1628110515.jpg?c=1",
                         Age = 17
                     },
                     new Character
                     {
                         Id = 2,
                         Name = "Gintoki Sakata",
                         ImageUrl = "https://images5.alphacoders.com/677/thumbbig-677361.webp",
                         Tier = 5,
                         Description = "Gintoki Sakata (坂田 銀時, Sakata Gintoki) is the main protagonist of the action comedy anime and manga series, Gintama. While usually coming across as lazy, selfish, greedy, and an overall jerk, he is a true hero who defends those who cannot fight for themselves and always keeps his promises to protect others and especially those close to him. He is a jack of all trades who runs his own business called the Yorozuya, who take on all manners of jobs for a small fee. He runs this business alongside his two friends, a young samurai-in-training Shimura Shinpachi and the young alien girl Kagura.",
                         Weapon = "butter knife",
                         WeaponImgUrl = "https://cdn11.bigcommerce.com/s-cykw02w8qi/images/stencil/1280x1280/products/8780/11530/1251183232773__99896__69563.1628110515.jpg?c=1",
                         Age = 15
                     },
                     new Character
                     {
                         Id = 3,
                         Name = "Ken Kaneki",
                         ImageUrl = "https://static.wikia.nocookie.net/tokyoghoul/images/7/7d/Kaneki_Finale_HQ.png/revision/latest?cb=20180706042331",
                         Tier = 3,
                         Description = "Ken Kaneki (金カネ木キ 研ケン, Kaneki Ken) is the main protagonist of the Tokyo Ghoul series. He is currently Touka Kirishima's husband, and the father of Ichika Kaneki. Previously, he was a student who studied Japanese literature at Kamii University, living a relatively normal life. However, this quickly changed after Rize Kamishiro's kakuhou was transplanted into him and transformed him into a one-eyed ghoul. Kaneki is the first known artificial one-eyed ghoul. His unique half ghoul state is what later inspires the idea of the Quinx. After joining Anteiku as a part-time waiter, he learns how to live as a ghoul and eventually becomes known as Eyepatch (眼帯, Gantai).",
                         Weapon = "sharper butter knife",
                         WeaponImgUrl = "https://cdn11.bigcommerce.com/s-cykw02w8qi/images/stencil/1280x1280/products/8780/11530/1251183232773__99896__69563.1628110515.jpg?c=1",
                         Age = 12
                     }
                 );

            modelBuilder.Entity<Weapon>().ToTable("Weapons").HasData(
                    new Weapon
                    {
                        Id = 2,
                        Name = "dogshit",
                        Description = "dogshit"
                    },
                    new Weapon
                    {
                        Id = 3,
                        Name = "dogshit1",
                        Description = "dogshit"
                    },
                    new Weapon
                    {
                        Id = 5,
                        Name = "dogshit2",
                        Description = "dogshit"
                    }
                );
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

    }
}
