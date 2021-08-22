namespace GeoCubed.Minimiez.Domain
{
    public class PlayAllPlacements
    {
        public int Round { get; set; }

        public int? HomeTeamId { get; set; }

        public int? AwayTeamId { get; set; }

        public int Score { get; set; }

        public string Path1 { get; set; }

        public string Path2 { get; set; }
    }
}
