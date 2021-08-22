using System;

namespace GeoCubed.Minimiez.Domain
{
    public class TourneyPlayed
    {
        public long UserId { get; set; }

        public int TourneyId { get; set; }

        public int Entrants { get; set; }

        public int Placement { get; set; }

        public DateTime TourneyDate { get; set; }
    }
}
