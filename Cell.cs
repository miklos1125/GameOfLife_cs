using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Cell
    {
        private bool alive;
        private bool signedToChange;
        private bool signedNotToCount;
        public static int height = 10;
        public static int width = 10;
        private int xLocation, yLocation;
        public static int population = 0; 

        public Cell(int x, int y) 
        {
            this.alive = false;
            // this.alive = (rand.Next(0,1000)%2==0) ? true:false;
            if (alive) population++;
            this.xLocation = x;
            this.yLocation = y;
        }

        public int x { get { return xLocation; } }
        public int y { get { return yLocation; } }
        public bool isAlive { get{ return alive; } }

        public bool isSignedNotToCount { get { return signedNotToCount; } }
        public bool setNoCountSign
        {
            set { signedNotToCount = value; }  
        }
        public void SigneItToChange() 
        {
            this.signedToChange = true;            
        }
        public void ChangeIfSigned() 
        {
            if (signedToChange) 
            {
                alive = !alive;
                signedToChange = false;
                population = alive ? population + 1 : population - 1;
            }
        }
    }
}
