namespace Lab2_sharps
{
    public class ColoredLine : Line
    {
        private string colore;

        public ColoredLine(int x, int y, int x1, int y1, string colore) : base(x, y, x1, y1)
        {
            this.colore = colore;
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