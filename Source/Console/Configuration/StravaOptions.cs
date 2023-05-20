namespace StravaActivityExtractor.Console.Configuration;
public class StravaOptions
{
    public const string Strava = "Strava";
    public string ApiToken { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
