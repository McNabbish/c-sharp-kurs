using System;

namespace Fr
{
    public class Frame
    {
        public int First = 0;
        public int Second = 0;
        public int FrameScore = 0;
        public Frame(int a, int b)
        {
             First = a;
             Second = b;

            while (First+Second > 10)
            {
                Console.WriteLine("Error, sum of both throws > 10, input correct numbers a,b");
                First = Convert.ToInt32(Console.ReadLine());
                Second = Convert.ToInt32(Console.ReadLine());
            }

        }

        public bool IsStrike()
        {
            if (First == 10)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsSpare()
        {
            if (First + Second == 10 && First != 10)
            {
                return true;
            }
            else
                return false;
        }

        public int Score()
        {
            return First + Second;
        }

    }

}

