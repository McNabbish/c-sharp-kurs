using Fr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var FrameList = new List<Frame>();
            int a=0;
            int b=0;
            int score = 0;
            int finalscore = 0;
    
            for (int i=0;i<12;i++)
            {
                Console.WriteLine("Throw {0}/10", i + 1);
                Console.WriteLine("Enter score on first throw");
                a=Convert.ToInt32(Console.ReadLine());
                if (a != 10)
                {
                    Console.WriteLine("Enter score on Second throw");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                else
                    b = 0;
                FrameList.Add(new Frame(a,b));

                for (int k = 0; k <= i; k++) // printing score per throw
                {
                    if (FrameList[k].IsSpare() == false && FrameList[k].IsStrike() == false)
                        Console.Write("|{0,2}|{1,2}|", FrameList[k].First, FrameList[k].Second);
                    else if ((FrameList[k].IsSpare() == true))
                        Console.Write("|{0,2}| /|", FrameList[k].First );
                    else if (FrameList[k].IsStrike() == true)
                        Console.Write("| X|{0,2}|", FrameList[k].Second);
                }
                
                Console.WriteLine();

                for (int j = 0; j <= i; j++) // printing total score
                {

                    if (FrameList[j].IsSpare() == false && FrameList[j].IsStrike() == false) // default, neither strike nor spare
                    {
                        score += FrameList[j].Score();
                        Console.Write("|{0,5}|", score);
                    }

                    else if (FrameList[j].IsSpare() == true && i >= (j + 1)) // spare
                    {
                        score += FrameList[j].Score() + FrameList[j + 1].First;
                        Console.Write("|{0,5}|", score);
                    }

                    else if ( i >= (j + 1) && FrameList[j+1].IsStrike() != true) // strike followed by non strike
                    {
                        score += FrameList[j].Score() + FrameList[j + 1].First + FrameList[j + 1].Second;
                        Console.Write("|{0,5}|", score);
                    }
                    else if ( i >= (j + 2) && FrameList[j + 1].IsStrike() == true) // strike followed by strike
                    {
                        score += FrameList[j].Score() + FrameList[j + 1].First + FrameList[j + 2].First;
                        Console.Write("|{0,5}|", score);
                    }
                }

                if (i==9 && FrameList[i].IsStrike() != true && FrameList[i].IsSpare() != true) //frame 10 was not spare || strike
                {
                    finalscore = score;
                    break;
                }


               else if (i == 10 && FrameList[9].IsSpare() == true) //frame 10 was a spare 
                {
                    finalscore = score - FrameList[10].Score();
                
                    break;
                }


             else if (i == 11 && FrameList[9].IsStrike() == true && FrameList[10].IsStrike() == true) //frame 10 was a strike followed by a strike
             {
                    finalscore = score;
                   break;
             }

             else if (i == 10 && FrameList[10].IsStrike() != true) //frame 10 was a strike followed by a non strike
             {
                    finalscore = score- FrameList[10].Score();
                    break;
             }

                score = 0;
                Console.WriteLine();

            }



            Console.WriteLine();
            Console.WriteLine("Final score is: {0}", finalscore);

            Console.ReadLine();



        }
    }
}
