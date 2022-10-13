namespace animeapi.Shared
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; } = String.Empty;
        public int Tier { get; set; }
        public string Description { get; set; } = String.Empty;
        public string Weapon { get; set; } = string.Empty;
        public string WeaponImgUrl { get; set; } = String.Empty;
        public int Age { get; set; }
    }
}
