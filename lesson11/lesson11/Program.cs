using System.IO;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main1(string[] args)
    {
        //Organize contents of any directory and it's files in the following style \

        //All image files should be in Images folder(png, jpg and etc.)
        //All video files should be in Videos folder(.mp4 and etc.)
        //All pdf and office files should be in Documents folder
        //All other files should in Other Files folder
        //Remove any empty directory

        string BasePath = "C:\\Users\\user\\Downloads";
        string Photo = "Photos";
        string PhotosPath = Path.Combine(BasePath, Photo);
        if (!Directory.Exists(PhotosPath))
        {
            Directory.CreateDirectory(PhotosPath);
            Console.WriteLine("Photo folder created succesfully");
        }
        else
        {
            Console.WriteLine("Photo folder has ");
        }


        string[] mp4Files = Directory.GetFiles(PhotosPath, "*.mp4");
        foreach (var file in mp4Files)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(PhotosPath, fileName);

            if (!File.Exists(destinationPath))
            {
                File.Move(file, destinationPath);
            }
        }


        string Videos = "Videos";

        string VideoPath = Path.Combine(BasePath, Videos);

        if (!Directory.Exists(VideoPath))
        {
            Directory.CreateDirectory(VideoPath);
            Console.WriteLine("Videos folder created succesfully");
        }
        else
        {
            Console.WriteLine("Videos folder already has");
        }


        string Document = "Doucment";

        string DocumentPath = Path.Combine(BasePath, Document);

        if (!Directory.Exists(DocumentPath))
        {
            Directory.CreateDirectory(DocumentPath);
            Console.WriteLine("Document folder created succesfully");
        }
        else
        {
            Console.WriteLine("Document folder has already");
        }


        string Other = "Other";
        string OtherPath = Path.Combine(BasePath, Other);

        if (!Directory.Exists(OtherPath))
        {
            Directory.CreateDirectory(OtherPath);
            Console.WriteLine("Other folder created succesfully");
        }
        else
        {
            Console.WriteLine("Other folder has already");
        }



    }
}