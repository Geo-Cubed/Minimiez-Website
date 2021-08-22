namespace GeoCubed.Minimiez.Domain
{
    public class Teams
    {
        public long UserId { get; set; }

        public double Rank { get; set; }

        public string TeamName { get; set; }

        public int MemberCount { get; set; }

        public long Captain { get; set; }

        public bool Confirmed { get; set; }

        public bool CheckedIn { get; set; }
    }
}
