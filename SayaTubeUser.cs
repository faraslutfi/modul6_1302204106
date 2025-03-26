using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    private string username;

    public SayaTubeUser(string username)
    {
        Debug.Assert(username != null, "Username tidak boleh null");
        Debug.Assert(username.Length <= 100, "Username tidak boleh lebih dari 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video yang ditambahkan tidak boleh null");
        Debug.Assert(video.PlayCount < int.MaxValue, "Play count video tidak boleh melebihi batas maksimum integer");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.PlayCount;
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");

        int maxVideosToPrint = Math.Min(8, uploadedVideos.Count); // Batasi maksimal 8 video

        for (int i = 0; i < maxVideosToPrint; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}");
        }
    }
}