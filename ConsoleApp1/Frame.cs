using System;

namespace Fr
{
    public class Frame
    {
        public Frame(int a, int b)
        {
            int First = 0;
            int Second = 0;
        }

        public bool IsStrike()
        {
            if (First == 10)
                return true;
            else
                return false;
        }

        public bool IsSpare()
        {
            if (First + Second == 10)
                return true;
            else
                return false;
        }

    }

}

