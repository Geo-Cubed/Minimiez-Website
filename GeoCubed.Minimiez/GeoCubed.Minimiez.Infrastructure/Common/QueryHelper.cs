namespace GeoCubed.Minimiez.Infrastructure.Common
{
    internal static class QueryHelper
    {
        internal const string Participants = "Participants";
        internal const string PlayAllPlacements = "PAP";
        internal const string Pools = "Pools";
        internal const string Teams = "Teams";
        internal const string Tournaments = "Tournaments";
        internal const string TourneyPlayed = "TourneyPlayed";
        internal const string Users = "Users";

        internal static string SelectAllStatement(string tbl)
        {
            return string.Format("select * from {0};", tbl);
        }
    }
}
