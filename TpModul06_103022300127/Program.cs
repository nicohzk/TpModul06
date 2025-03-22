class SayaTubeVideo {
    private int id;
    private String title;
    private int PlayCount;

    public SayaTubeVideo(String judul)
    {
        this.title = judul;
        Random rand = new Random();
        this.id = rand.Next(10000,99999);
        this.PlayCount = 0;
    }

    public void IncreasePlayCount(int play) {
        this.PlayCount += play;
    }

    public void PrintVideoDetails() {
        Console.WriteLine("id = " + this.id);
        Console.WriteLine("title = " + this.title);
        Console.WriteLine("playCount = " + this.PlayCount);
    }
}

public class system {
    public static void Main() {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Hizkia Nicander Budiyanto");
        video.PrintVideoDetails();
    }

}
