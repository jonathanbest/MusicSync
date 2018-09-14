using Sync.Library.Deezer;
using System;
using Xunit;

namespace Sync.Library.Tests
{
    public class AlbumTests
    {
        [Fact]
        public void AlbumId_WhenExists_RetrieveDetails()
        {
            int input = 302127;
            string expected = "Discovery";

            AlbumFetcher albumFetch = new AlbumFetcher();
            var album = albumFetch.Get(input);

            Assert.Equal(expected, album.Title);
        }
    }
}
