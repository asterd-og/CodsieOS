using CodsieOS.Drivers.Graphics;
using System.Drawing;
using Cosmos.System;

namespace CodsieOS.Interface
{
    class Cursor
    {
        public int PosX = 50, PosY = 50;
        public readonly int Width = 8, Height = 13;
        public readonly byte[] PixelData = new byte[]
        {
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 1, 0, 0, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0, 0,
            1, 2, 1, 1, 0, 0, 0, 0,
            1, 2, 2, 1, 1, 0, 0, 0,
            1, 2, 2, 2, 1, 1, 0, 0,
            1, 2, 2, 2, 2, 1, 1, 0,
            1, 2, 2, 2, 2, 0, 1, 1,
            1, 2, 2, 2, 2, 1, 1, 1,
            1, 2, 1, 1, 2, 1, 0, 0,
            1, 2, 1, 1, 1, 2, 1, 0,
            1, 1, 1, 0, 1, 1, 1, 0,
            1, 1, 0, 0, 0, 1, 1, 0,
        };

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (PixelData[i * Width + j] == 0) continue;
                    if (PixelData[i * Width + j] == 1)
                        Canvas.DrawPixel(PosX + j, PosY + i, Color.Black);
                    else
                        Canvas.DrawPixel(PosX + j, PosY + i, Color.White);
                }
            }
        }

        public void Update()
        {
            PosX = (int) MouseManager.X;
            PosY = (int) MouseManager.Y;
        }

        public void Initialize(uint posX, uint posY, float sensivity)
        {
            MouseManager.ScreenWidth = 800;
            MouseManager.ScreenHeight = 600;

            MouseManager.X = posX;
            MouseManager.X = posY;

            MouseManager.MouseSensitivity = sensivity;
        }
    }
}
