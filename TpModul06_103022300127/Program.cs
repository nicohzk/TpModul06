using System.Diagnostics.Contracts;
class SayaTubeVideo {
    private int id;
    private String title;
    private int PlayCount;

    public SayaTubeVideo(String judul)
    {
        Random rand = new Random();

            
        Contract.Requires(judul != null);
        Contract.Requires(judul.Length <= 100);

            
        if (judul == null)
        {    
            throw new Exception("title tidak boleh Null");
        }
            
        if (judul.Length >= 100) {
            throw new Exception("Judul tidak boleh lebih dari 100 char");
            
        }
        this.title = judul;
        this.id = rand.Next(10000,99999);
        this.PlayCount = 0;
    }

        
    public void IncreasePlayCount(int play) {            
        try            
        {       
            Contract.Requires(play <= 10000000, "Input penambahan play count maksimal 10.000.000 per panggilan method-nya.");            
            checked            
            {            
                this.PlayCount += play;                
            }        
        }
            
        catch (OverflowException e) {        
            Console.WriteLine("Error: Play count melebihi batas maksimum integer.");  
        }
        
    }

    
    public void PrintVideoDetails() {
        Console.WriteLine("id = " + this.id);
        Console.WriteLine("title = " + this.title);
        Console.WriteLine("playCount = " + this.PlayCount);
        
    }
}
public class system {
    public static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            string judul;
            Console.Write("Masukkan Judul: ");
            judul = Console.ReadLine();
            try
            {

                SayaTubeVideo video = new SayaTubeVideo(judul);
                video.PrintVideoDetails();
                video.IncreasePlayCount(1000000000);
                video.IncreasePlayCount(2000000000);
                video.PrintVideoDetails();
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }

        }
    }
}
