using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class PhotoAlbum
    {
        protected int numberOfPages;

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int n)
        {
            numberOfPages = n;
        }
    }
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
    }
    class AlbumTest
    {
        static void Main()
        {
            PhotoAlbum album1 = new PhotoAlbum();
            Console.WriteLine("Number of pages album1: " + album1.GetNumberOfPages());
            

            PhotoAlbum album2 = new PhotoAlbum(24);
            Console.WriteLine("Number of pages album2: " + album2.GetNumberOfPages());

            BigPhotoAlbum album3 = new BigPhotoAlbum();
            Console.WriteLine("Number of pages album3: " + album3.GetNumberOfPages());
        }

    }

}
