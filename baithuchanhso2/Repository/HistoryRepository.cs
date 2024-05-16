
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanhso2.Repository
{
    internal class HistoryRepository
    {
        private string dataFolderPath;

        public HistoryRepository(string dataFolderPath)
        {
            this.dataFolderPath = dataFolderPath;
        }

        public List<History> LoadSongs()
        {
            var songs = new List<History>();
            string filePath = Path.Combine(dataFolderPath, "song_history.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 6)
                    {
                        var song = new History
                        {
                            Title = parts[0],
                            Author = parts[1],
                            Artist = parts[2],
                            FilePath = Path.Combine(dataFolderPath, "Audio", parts[3]),
                            CoverPath = Path.Combine(dataFolderPath, "Images", parts[4]),
                            Time = parts[5],
                        };
                        songs.Add(song);
                    }
                }
            }

            return songs;
        }
    }
}
