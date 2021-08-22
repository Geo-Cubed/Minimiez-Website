namespace GeoCubed.Minimiez.Domain
{
    public class Participants
    {
        public int Seed { get; set; }

        public string TeamName { get; set; }

        public long CaptainId { get; set; }

        public int? Score { get; set; }

        public string Round { get; set; }

        public string Pool { get; set; }

        public int Placement { get; set; }

        public string Bracket { get; set; }
    }
}
