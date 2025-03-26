using System;

class Program
{
    static void Main()
    {
        // Membuat objek SayaTubeUser
        SayaTubeUser user = new SayaTubeUser("Faras Imam Lutfi Irzan");

        // Menambahkan video ke user
        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Faras Irzan");
            user.AddVideo(video);
        }

        // Menampilkan semua video
        user.PrintAllVideoPlaycount();

        Console.ReadLine(); // supaya console ga ketutup
    }

}