namespace intro_to_vstudio_Y9
{
    internal class Program
    {
        static void Main(string[] args)
        { bool accessgranted = false;
    while (accessgranted = true){
        Console.WriteLine("Please enter username");
        string username = Console.ReadLine();
        Console.WriteLine("PLease enter the password that goes with that username");
        string password = Console.ReadLine();
        if (username == "Yusuf5"){
            while(password == "33kk"){
                Console.WriteLine("Access Granted");
                accessgranted = true;
            }
            
                Console.WriteLine("Access denied");
            }
            else if (username == "Mary80"){
                while(password == "af5r"){
                    Console.WriteLine("Access Granted");
                    accessgranted = true;
                }
                Console.WriteLine("Access Denied");
            }
    }
        }
    }
}
 
