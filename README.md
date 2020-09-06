# LastFM.AspNetCore.Stats

.NET Core API to access Last.fm user stats

# Usage

## Init

```csharp
LastFMCredentials credentials = new LastFMCredentials()
{
    APIKey = xxx,
    SharedSecret = xxx
};

LastFMStatsService lastFMStatsService = new LastFMStatsService(LastFMCredentials credentials);
```

## Available methods

```csharp
Task<LastFMUser> LastFMUser = lastFMStatsService.GetUserInfo(username);
Task<IEnumerable<Album>> TopAlbums = lastFMStatsService.GetTopAlbums(username);
Task<IEnumerable<Artist>> TopArtists = lastFMStatsService.GetTopArtists(username);
Task<IEnumerable<Track>> topTracks = lastFMStatsService.GetTopTracks(username);
Task<IEnumerable<Track>> recentTracks = lastFMStatsService.GetRecentTracks(username);
```
