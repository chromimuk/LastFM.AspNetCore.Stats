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

### User

```csharp
Task<LastFMUser> LastFMUser = lastFMStatsService.GetUserInfo(username);
Task<IEnumerable<Album>> TopAlbums = lastFMStatsService.GetUserTopAlbums(username);
Task<IEnumerable<Artist>> TopArtists = lastFMStatsService.GetUserTopArtists(username);
Task<IEnumerable<Track>> topTracks = lastFMStatsService.GetUserTopTracks(username);
Task<IEnumerable<Track>> lovedTracks = lastFMStatsService.GetUserLovedTracks(username);
Task<IEnumerable<Track>> recentTracks = lastFMStatsService.GetUserRecentTracks(username);
```

### Artist

```csharp
Task<Artist> artist = lastFMStatsService.GetArtistInfo(searchedArtist);
Task<IEnumerable<Artist>> similarArtists = lastFMStatsService.GetSimilarArtists(searchedArtist);
Task<IEnumerable<Album>> albums = lastFMStatsService.GetArtistTopAlbums(searchedArtist);
Task<IEnumerable<Track>> tracks = lastFMStatsService.GetArtistTopTracks(searchedArtist);
```

### Album

```csharp
Task<Album> album = lastFMStatsService.GetAlbumInfo(artistName, albumName);
```
