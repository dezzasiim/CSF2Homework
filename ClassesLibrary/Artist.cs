using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        public List<Song> Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        //ctor
        public Artist(List<Song> tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }
        public Artist() { }
        //methods
        public override string ToString()
        {
            string listOfTracks = "";

            foreach (Song song in Tracks)
            {
                listOfTracks += song + "\n";
            }
            return string.Format("{0}{1}{2}",
                listOfTracks,
                Title,
                Genre);
        }
    }
}
