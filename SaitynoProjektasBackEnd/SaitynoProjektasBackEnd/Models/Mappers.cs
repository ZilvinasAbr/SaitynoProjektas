﻿using System.Linq;
using SaitynoProjektasBackEnd.ResponseModels;

namespace SaitynoProjektasBackEnd.Models
{
    public class Mappers
    {
        public static SongResponseModel SongToSongResponseModel(Song song) =>
            new SongResponseModel
            {
                Id = song.Id,
                Description = song.Description,
                Duration = song.Duration,
                Genre = song.Genre.Name,
                Likes = song.Likes.Count,
                PictureUrl = song.PictureUrl,
                Plays = song.Plays,
                Title = song.Title,
                UploadDate = song.UploadDate,
                UploaderName = song.User.UserName,
                FilePath = song.FilePath
            };

        public static SongResponseModel PlaylistSongToSongResponseModel(PlaylistSong playlistSong) =>
            new SongResponseModel
            {
                Id = playlistSong.Song.Id,
                TrackNumber = playlistSong.Number,
                Title = playlistSong.Song.Title,
                Description = playlistSong.Song.Description,
                UploadDate = playlistSong.Song.UploadDate,
                PictureUrl = playlistSong.Song.PictureUrl,
                Duration = playlistSong.Song.Duration,
                Plays = playlistSong.Song.Plays,
                UploaderName = playlistSong.Song.User.UserName,
                Genre = playlistSong.Song.Genre.Name,
                Likes = playlistSong.Song.Likes.Count,
                FilePath = playlistSong.Song.FilePath
            };

        public static UserResponseModel UserToUserResponseModel(User user) =>
            new UserResponseModel
            {
                Name = user.UserName,
                Location = user.Location,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Description = user.Description
            };

        public static PlaylistResponseModel PlaylistToPlaylistResponseModel(Playlist playlist) =>
            new PlaylistResponseModel
            {
                Id = playlist.Id,
                Name = playlist.Name,
                Description = playlist.Description,
                IsPublic = playlist.IsPublic,
                UserName = playlist.User.UserName,
                Likes = playlist.Likes.Count,
                Songs = playlist.PlaylistSongs.Select(PlaylistSongToSongResponseModel)
            };

        public static EventResponseModel EventToEventResponseModel(Event e) =>
            new EventResponseModel
            {
                Id = e.Id,
                CreatedOn = e.CreatedOn,
                EventType = e.EventType,
                SongTitle = e.Song.Title,
                UserName = e.User.UserName
            };
    }
}
