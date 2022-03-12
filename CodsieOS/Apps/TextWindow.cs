using CodsieOS.Drivers.Graphics;
using System.Drawing;

namespace CodsieOS.Apps
{
    class TextWindow : Window
    {
        public char[] Buffer = new char[80 * 25];

        protected override void DrawContent(int x, int y)
        {
            Canvas.DrawFilledRectangle(x, y, Width, Height, Color.Black);
        }

    }
}
