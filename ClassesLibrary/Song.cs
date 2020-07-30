using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {

        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }
        //ctors
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }
        public Song() { }
        //methods
        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Artist, Title, LengthInSeconds);
        }

    }
}
