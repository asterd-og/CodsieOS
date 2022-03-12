namespace CodsieOS.Interface
{
    class InterfaceManager
    {
        bool IsOnDesktop = true;
        Desktop desktop;
        Taskbar taskbar;
        Cursor cursor;

        Core.WindowManager windowManager = new Core.WindowManager();

        public InterfaceManager()
        {
            desktop = new();
            taskbar = new();
            cursor = new();
            cursor.Initialize(400, 300, 1f);
        }        

        public void DrawInterface()
        {
            desktop.Draw();
            taskbar.Draw();

            windowManager.DrawWindows();

            cursor.Update();
            cursor.Draw();
        }
    }
}
