using Sys = Cosmos.System;
using CodsieOS.Drivers.Graphics;

namespace CodsieOS
{
    public class Kernel : Sys.Kernel
    {

        Drivers.Graphics.VBE vbe;
        Drivers.Graphics.Canvas canvas;

        Interface.InterfaceManager im = new();

        protected override void BeforeRun()
        {
            vbe = new(800, 600); // must not be ininitialized in a global instance
            canvas = new(); // must not be ininitialized in a global instance

            Canvas.Clear();

            Core.AppManager.AddNewApp(new Apps.App("Test", Apps.WindowType.TextWindow));
            Core.AppManager.AddNewApp(new Apps.App("Test2", Apps.WindowType.TextWindow));
        }

        protected override void Run()
        {
            im.DrawInterface();

            canvas.Update();

            Cosmos.Core.Memory.Heap.Collect();
        }
    }
}
