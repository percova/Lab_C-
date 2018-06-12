using System;

namespace Lab2_sharps
{
    public class Line : Point
    {
        private int x;
        private int y;
        private int x1;
        private int y1;

        public Line(int x, int y, int x1, int y1)
        {
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
        
        public int getX1()
        {
            return this.x1;
        }

        public int getY1()
        {
            return this.y1;
        }

        public void setCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
        }

        public string getColore()
        {
            return null;
        }

        public void setColore(string colore)
        {
            colore = null;
        }
    }
}