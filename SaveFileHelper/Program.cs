namespace SaveFileHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (!File.Exists("users.bin"))
            {
                Console.WriteLine("Please add save file to the same directory as this program.");
                Thread.Sleep(1000);
                Console.Clear();
            }
               
            BinaryReader br = new BinaryReader(File.Open("users.bin", FileMode.Open));

            int usersCount = br.ReadInt32();

            for (int i = 0; i < usersCount; i++)
            {
                string name = br.ReadString();
                int gamesPlayed = br.ReadInt32();
                int wordsUsed = br.ReadInt32();
                Console.WriteLine($"{name}: gamesPlayed: {gamesPlayed}, wordsUsed: {wordsUsed}");
            }

            br.Close();
            Console.ReadKey();
        }
    }
}
