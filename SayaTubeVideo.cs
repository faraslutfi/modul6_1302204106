using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public string Title { get { return title; } }

    public int PlayCount { get { return playCount; } }

    // Constructor
    public SayaTubeVideo(string title)
    {
        // Generate ID secara acak 5 digit
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);

        // Inisialisasi title
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID Video: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}