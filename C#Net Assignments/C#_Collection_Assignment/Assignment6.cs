using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment_Music_Playlist
{
    internal class Song
    {
        public int Id;
        public string Title;
        public string Artist;
    }
    class Program
    {
        static void Main()
        {
            LinkedList<Song> playlist= new LinkedList<Song>();
            var s1 = new Song { Id = 1, Title = "Song1", Artist = "A" };
            var s2 = new Song { Id = 2, Title = "Song2", Artist = "B" };
            var s3 = new Song { Id = 3, Title = "Song3", Artist = "C" };

            playlist.AddLast(s1);
            playlist.AddLast(s2);
            playlist.AddAfter(playlist.First,s3);

            Console.WriteLine("Forward:");
            foreach(Song s in playlist) 
                Console.Write(s.Title);

            Console.WriteLine("\nBackward:");
            var node = playlist.Last;
            while (node != null)
            {
                Console.WriteLine(node.Value.Title);
                node = node.Previous;
            }

            var found = playlist.Find(s2);
            if(found!=null)
                playlist.Remove(found);

            Console.WriteLine("\nAfter Removal:");
            foreach(var s in playlist)
                Console.WriteLine(s.Title);

            foreach(var s in playlist)
            {
                if (s.Title == "Song1")
                    Console.WriteLine("\nFound: "+s.Title);
            }
        }
    }
}
