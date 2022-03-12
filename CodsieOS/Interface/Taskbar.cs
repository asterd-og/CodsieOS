using CodsieOS.Drivers.Graphics;
using System.Drawing;

namespace CodsieOS.Interface
{
    class Taskbar
    {
        public void Draw()
        {
            DrawBar();
            DrawDebugData();
        }

        public void DrawBar()
        {
            Canvas.DrawFilledRectangle(0, Canvas.Height - 20, Canvas.Width, 20, Color.FromArgb(255, 41, 41, 41));
        }

        public void DrawDebugData()
        {
            Canvas.DrawString(0, Canvas.Height - 18, "Codsie OS build 0.0.1", Color.White);
            Canvas.DrawString(Canvas.Width - 64, Canvas.Height - 18, "FPS:" + Canvas.FPS.ToString(), Color.White);
        }
    }
}
