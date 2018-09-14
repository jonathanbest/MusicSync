using Sync.Library.Models;
using System;

namespace Sync.Library.Deezer
{
    public class AlbumFetcher
    {
        public AlbumFetcher()
        {

        }

        public Album Get(int id)
        {
            //https://api.deezer.com/album/302127

            return new Album
            {
                Title = "Discovery"
            };
        }
    }
}
