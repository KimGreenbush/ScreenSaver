using System;
using static System.Console;
using System.Threading;

namespace v_kgreenbush
{
    class Phrase
    {
        string text = "Maybe it's Maybelline";
        int xCoord;
        int yCoord;
        int xDir = 1;
        int yDir = 1;

        public Phrase()
        {
            xCoord = 0;
            yCoord = 0;
        }

        public void MovePhrase()
        {
            int wHeight = WindowHeight;
            int wWidth = WindowWidth;

            // check Phrase position with window edges
            // separate method
            bool edge = false;

            // change direction of phrase if hear the border
            if(edge)
            {

            }
        }

        bool IsNearBorder()
        {
            // check if phrase is near border
            // cursor width posion + phrase length > width
            // cursor height posion + phrase length > height
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Phrase screensaver = new Phrase();

            screensaver.MovePhrase();

        }
    }
}
