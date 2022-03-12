using CodsieOS.Drivers.Graphics;
using System.Drawing;

namespace CodsieOS.Apps
{

    enum WindowState
    {
        Minimized,
        Normal,
        Maximized
    }

    enum WindowType
    {
        TextWindow,
        GraphicsWindow,
    }

    abstract class Window
    {
        public string DisplayName;
        public WindowState State = WindowState.Normal;
        public int OffsetX = 50, OffsetY = 50;
        public int Width = 320, Height = 200;

        public void Draw()
        {
            DrawFrame(OffsetX, OffsetY);
            DrawContent(OffsetX, OffsetY + 20);
        }

        private void DrawFrame(int x, int y)
        {
            Canvas.DrawFilledRectangle(x, y, Width, 20, Color.White);
            Canvas.DrawString(x, y+2, DisplayName, Color.Black);
        }

        protected abstract void DrawContent(int x, int y);
    }
}
