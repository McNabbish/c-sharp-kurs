using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    class Program
    {
        static void Main()
        {
            int Players=0;
            var PlayerList = new List<Player>();
            string Name;


            try
            {


                Console.WriteLine("enter number of players: ");
                Players = Convert.ToInt32(Console.ReadLine());
            }


            catch(Exception e)
            {
                Console.WriteLine("Error in input: {0}", e);
            }

            for (int i=0;i<Players;i++)
            {
                try
                {
                    Console.WriteLine("Player {0}, please input your name: ", i + 1);
                    Name = Console.ReadLine();
                    PlayerList.Add(new Player(Name));
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error in input: {0}", e);
                }
            }

            for (int i=0; i<12;i++)
            {
                for (int j=0; j<Players;j++)
                { 
                    PlayerList[j].Throw();
                    PlayerList[j].PrintThrows();
                    PlayerList[j].CalcScore();
                }

            }


            Console.ReadLine();
        }
    }
}
