namespace Lab2_sharps
{
    public class ColoredPoint : Point
    {
        private int x;
        private int y;
        private string colore;

        public ColoredPoint()
        {
            x = 0;
            y = 0;
            colore = "none";
        }
        public ColoredPoint(int x, int y, string colore)
        {
            this.x = x;
            this.y = y;
            this.colore = colore;
        }

        public int getX()
        {
            return this.x;
        }
        
        public int getY()
        {
            return this.y;
        }
        
        public void setCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string getColore()
        {
            return this.colore;
        }

        public void setColore(string color)
        {
            this.colore = color;
        }
        
    }
}