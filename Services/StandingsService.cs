using DynastyHq.Repositories;

namespace DynastyHq.Services;

public static class StandingsService
{
    public static List<int> GetStandingsByLeagueId(int leagueId)
    {
        return UserLeagueRepository.GetUserLeaguesByLeagueId(leagueId);
    }
}
