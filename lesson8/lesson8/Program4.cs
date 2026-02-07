using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson8
{
    internal class Program4
    {
        public static void Main4()
        {
            //Create a C# program to manage a photo book using object-oriented programming.

            //To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.

            //The default constructor will create an album with 16 pages.There will be an additional constructor, with which we can specify the number of pages we want in the album.

            //There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

            //Finally create a PhotoBookTest class to perform the following actions:

            //Create a default photo book and show the number of pages
            //Create a photo book with 24 pages and show the number of pages
            //Create a large photo book and show the number of pages

            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine(photoBook.GetNumberPages());
            Console.WriteLine();

            PhotoBook photoBook2 = new PhotoBook(24);
            Console.WriteLine(photoBook2.GetNumberPages());
            Console.WriteLine();


            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine( bigPhotoBook.GetNumberPages());


        }
    }

    public class PhotoBook
    {
       protected int NumPages;

        public int GetNumberPages()
        {
            return NumPages;
        }

        public PhotoBook()
        {
            NumPages = 16;
        }

        public PhotoBook(int numPages)
        {
            NumPages = numPages;
        }
    }
    public class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            NumPages = 64;
        }
    }
  
}
