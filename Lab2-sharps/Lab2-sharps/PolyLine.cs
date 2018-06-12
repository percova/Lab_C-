namespace Lab2_sharps
{
    public class PolyLine : Line
    {
        private int x2;
        private int y2;
        private int x3;
        private int y3;

        public PolyLine(int x, int y, int x1, int y1, int x2, int y2, int x3, int y3) : base(x, y, x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public int getX2()
        {
            return this.x2;
        }

        public int getY2()
        {
            return this.y2;
        }
        
        public int getX3()
        {
            return this.x3;
        }

        public int getY3()
        {
            return this.y3;
        }

        public void setCoordinates1(int x2, int y2, int x3, int y3)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
    }
}