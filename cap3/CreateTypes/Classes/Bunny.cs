namespace CreateTypes.Classes
{
    public class Bunny
    {
        public string Name { get; set; }

        public bool LikeCarrots { get; set; }
        public bool LikeHumans { get; set; }

        public Bunny() { }

        public Bunny(string name)
        {
            Name = name;
        }

        public Bunny(string name,
        bool likeCarrots = false,
        bool likeHumans = false)
        {
            Name = name;
            LikeCarrots = likeCarrots;
            LikeHumans = likeHumans;
        }
    }
}