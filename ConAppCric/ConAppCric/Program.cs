using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> listPlayers = new List<Player>()
            {
                new Player{ Id=1,Name="MSD",Team="CSK",Mfee=300000.89},
                new Player{ Id=2,Name="H.Pandya",Team="GT",Mfee=400000.89},
                new Player{ Id=3,Name="Umran Malik",Team="SRH",Mfee=300000.89},
                new Player{ Id=4,Name="DK",Team="MI",Mfee=300000.89},
                new Player{ Id=5,Name="VK",Team="RCB",Mfee=300000.89}

            };
            Console.WriteLine("number of players"+listPlayers.Count);
            foreach (Player player in listPlayers)
            {
                Console.WriteLine("ID:"+player.Id);
                Console.WriteLine("Name: "+player.Name);
                Console.WriteLine("Team:" +player.Team);
                Console.WriteLine("Match fee"+player.Mfee);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
