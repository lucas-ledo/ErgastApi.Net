using ErgastApi.Requests.Attributes;
using ErgastApi.Responses;

namespace ErgastApi.Requests.Other
{
    public class LapTimesRequest : ErgastRequest<IRaceResponse<IRaceWithLapTimes>>
    {
        public LapTimesRequest()
        {
        }

        public LapTimesRequest(ErgastRequestSettings settings) : base(settings)
        {
        }

        [QueryTerminator, QueryMethod("laps")]
        public int? Lap { get; set; }

        [QueryMethod("pitstops")]
        public int? PitStop { get; set; }
    }
}