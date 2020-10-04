namespace LastFM.AspNetCore.Stats.Entities
{
    public class LastFMUser
    {
        public string Name { get; set; }

        public string URL { get; set; }

        public Image Image { get; set; }

        public long Playcount { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}