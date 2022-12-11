using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using DynastyHq.Services;

namespace DynastyHq.Triggers;
public class StandingsTrigger
{
    [Function("GetStandings")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteAsJsonAsync<object>(StandingsService.GetStandingsByLeagueId(1));

        return response;
    }
}
