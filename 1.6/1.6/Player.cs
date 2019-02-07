using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    class Player
    {
        public string name;
        public bool IsDone;
        public int index;
        public List<Frame> FrameList;
        Random Rng = new Random();
        int First;
        int Second;

        int score = 0;
       public int finalscore = 0;

        public Player(string a) // constructor
        {
            name = a;
            IsDone = false;
            FrameList = new List<Frame>(12);
            index = 0;
        }

        void AddFrame(int a, int b)  // adding frame to list containing throw data
        {
            FrameList.Add(new Frame(a,b));
        }

        public void Throw() // generates random numbers and calls adframe to store data as a frame, to simulate strikes only change rng range
        {
            if (IsDone != true)
            {
                Console.WriteLine("{0}, press any key to throw first ball",name);
                Console.ReadKey();
                First = Rng.Next(0, 11);
                Console.WriteLine("You hit {0} pins", First);

                if (First != 10)
                {
                    Console.WriteLine("{0}, press any key to throw second ball",name);
                    Console.ReadKey();
                    Second = Rng.Next(0, (10 - First + 1));
                    Console.WriteLine("Strike");
                }
                else
                    Second = 0;

                AddFrame(First, Second);
                index++;

            }

        }



        public void PrintThrows() // print both throws in each frame, / and x if spare or strike
        {
            Console.WriteLine("{0} Serie: ", name);
            for (int k = 0; k <= (index-1); k++) // printing score per throw
            {
                if (FrameList[k].IsSpare() == false && FrameList[k].IsStrike() == false)
                    Console.Write("|{0,2}|{1,2}|", FrameList[k].First, FrameList[k].Second);
                else if ((FrameList[k].IsSpare() == true))
                    Console.Write("|{0,2}| /|", FrameList[k].First);
                else if (FrameList[k].IsStrike() == true)
                    Console.Write("| X|{0,2}|", FrameList[k].Second);
            }
            Console.WriteLine();
        }

        public void CalcScore() // Sum up score at each frame, special cases for strikes, spares. sets Bool:IsDone to true at completed conditions
        {
            for (int j = 0; j < index; j++) // printing total score
            {

                if (FrameList[j].IsSpare() == false && FrameList[j].IsStrike() == false && j<10) // default, neither strike nor spare
                {
                    score += FrameList[j].Score();
                    Console.Write("|{0,5}|", score);
                }

                else if (FrameList[j].IsSpare() == true && index > (j + 1) && j < 10) // spare
                {
                    score += FrameList[j].Score() + FrameList[j + 1].First;
                    Console.Write("|{0,5}|", score);
                }

                else if (index > (j + 1) && FrameList[j + 1].IsStrike() != true && j < 10) // strike followed by non strike
                {
                    score += FrameList[j].Score() + FrameList[j + 1].First + FrameList[j + 1].Second;
                    Console.Write("|{0,5}|", score);
                }
                else if (index > (j + 2) && FrameList[j + 1].IsStrike() == true && j < 10) // strike followed by strike
                {
                    score += FrameList[j].Score() + FrameList[j + 1].First + FrameList[j + 2].First;
                    Console.Write("|{0,5}|", score);
                }
            }

            if (index == 10 && FrameList[9].IsStrike() != true && FrameList[9].IsSpare() != true) //frame 10 was not spare || strike
            {
                IsDone = true;
            }


            else if (index == 11 && FrameList[9].IsSpare() == true) //frame 10 was a spare 
            {
                IsDone = true;
            }


            else if (index == 12 && FrameList[9].IsStrike() == true && FrameList[10].IsStrike() == true) //frame 10 was a strike followed by a strike
            {
                IsDone = true;
            }

            else if (index == 11 && FrameList[10].IsStrike() != true) //frame 10 was a strike followed by a non strike
            {
                IsDone = true;
            }

            score = 0;

            Console.WriteLine();
        }
    }
}
