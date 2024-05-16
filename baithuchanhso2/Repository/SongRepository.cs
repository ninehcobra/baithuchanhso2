using System;
using System.Collections.Generic;
using System.IO;

public class SongRepository
{
    private string dataFolderPath;

    public SongRepository(string dataFolderPath)
    {
        this.dataFolderPath = dataFolderPath;
    }

    public List<Song> LoadSongs()
    {
        var songs = new List<Song>();
        string filePath = Path.Combine(dataFolderPath, "songs.txt");

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 6)
                {
                    var song = new Song
                    {
                        Title = parts[0],
                        Author = parts[1],
                        Artist = parts[2],
                        FilePath = Path.Combine(dataFolderPath, "Audio", parts[3]),
                        CoverPath = Path.Combine(dataFolderPath, "Images", parts[4]),
                        Genre = parts[5],
                    };
                    songs.Add(song);
                }
            }
        }

        return songs;
    }
}
