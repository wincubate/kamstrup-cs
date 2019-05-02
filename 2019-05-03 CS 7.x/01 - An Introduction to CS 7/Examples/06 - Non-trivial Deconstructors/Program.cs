using Wincubate.CS7.DiscographyLib;

using System;
using static System.Console;

namespace Wincubate.CS7.Slide06
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album(
                "Depeche Mode",
                "Violator",
                new DateTime( 1990, 3, 19 )
            );

            //(Guid guid, string summary, int age) = album;
            //WriteLine( $"{summary} is {age} years old");
        }
    }

    #region ...

    //
    // Extension Deconstructors = <3 <3 <3
    //

    //static class AlbumExtensions
    //{
    //    public static void Deconstruct( this Album album, out Guid id, out string summary, out int age )
    //    {
    //        id = album.Id;

    //        summary = $"\"{album.AlbumName}\" by {album.Artist}";

    //        DateTime today = DateTime.Now;
    //        age = today.Year - album.ReleaseDate.Year - (album.ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
    //    }
    //}

    #endregion
}