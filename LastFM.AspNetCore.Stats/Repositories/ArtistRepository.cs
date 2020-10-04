using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Responses;
using LastFM.AspNetCore.Stats.Responses.Artist;
using LastFM.AspNetCore.Stats.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    internal class ArtistRepository : LastFMRepository, IArtistRepository
    {
        public ArtistRepository(LastFMCredentials credentials, IMapper mapper) : base(credentials, mapper)
        {
        }

        public async Task<Artist> GetInfoAsync(string searchedArtist)
        {
            if (searchedArtist == null)
                return null;

            string artistGetInfosURL = $"/2.0/?method=artist.getinfo&artist={searchedArtist}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(artistGetInfosURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetArtistInfosResponse artistResponse = GetArtistInfosResponse.FromJson(jsonString);

            Artist artist = _mapper.Map<Artist>(artistResponse.Artist);
            return artist;
        }

        public async Task<IEnumerable<Artist>> GetSimilarAsync(string searchedArtist, int limit = 10)
        {
            if (searchedArtist == null)
                return null;

            string artistGetSimilarURL = $"/2.0/?method=artist.getSimilar&artist={searchedArtist}&limit={limit}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(artistGetSimilarURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetSimilarArtistResponse artistResponse = GetSimilarArtistResponse.FromJson(jsonString);

            IEnumerable<Artist> artists = _mapper.Map<IEnumerable<Artist>>(artistResponse.SimilarArtists.Artists);
            return artists;
        }

        public async Task<IEnumerable<Album>> GetTopAlbumsAsync(string searchedArtist, int limit = 10)
        {
            if (searchedArtist == null)
                return null;

            string artistGetTopAlbumsURL = $"/2.0/?method=artist.getTopAlbums&artist={searchedArtist}&limit={limit}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(artistGetTopAlbumsURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetArtistTopAlbumsResponse artistResponse = GetArtistTopAlbumsResponse.FromJson(jsonString);

            IEnumerable<Album> albums = _mapper.Map<IEnumerable<Album>>(artistResponse.TopAlbums.Albums);
            return albums;
        }

        public async Task<IEnumerable<Track>> GetTopTracksAsync(string searchedArtist, int limit = 10)
        {
            if (searchedArtist == null)
                return null;

            string artistGetSimilarURL = $"/2.0/?method=artist.getTopTracks&artist={searchedArtist}&limit={limit}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(artistGetSimilarURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetArtistTopTracksResponse artistResponse = GetArtistTopTracksResponse.FromJson(jsonString);

            IEnumerable<Track> artists = _mapper.Map<IEnumerable<Track>>(artistResponse.TopTracks.Tracks);
            return artists;
        }
    }
}