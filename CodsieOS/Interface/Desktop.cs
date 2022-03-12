using CodsieOS.Drivers.Graphics;
using System.Drawing;

namespace CodsieOS.Interface
{
    class Desktop
    {
        public void Draw()
        {
            DrawBackground();
        }

        public void DrawBackground()
        {
            Canvas.Clear(Color.FromArgb(255, 54, 94, 53));
        }

        public void DrawIcons()
        {

        }
    }
}
