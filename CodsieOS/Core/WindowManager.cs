using CodsieOS.Apps;

namespace CodsieOS.Core
{
    class WindowManager
    {
        public void DrawWindows()
        {
            foreach (App app in AppManager.Applications)
            {
                app.Window.Draw();
            }
        }
    }
}
