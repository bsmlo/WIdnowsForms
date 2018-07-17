using System.Drawing;

namespace Rain
{
    public class Drop
    {
        public Point Location = new Point(0, 0);
        public int size = 10;

        public Drop(Point loc)
        {
            Location = loc;
        }

        public void Paint(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, Location.X, Location.Y, size, size);
        }
    }
}
