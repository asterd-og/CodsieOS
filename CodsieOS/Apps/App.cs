namespace CodsieOS.Apps
{
    class App
    {
        public string Name;
        public Window Window;

        public App(string name, WindowType type)
        {
            Name = name;

            if (type == WindowType.TextWindow)
                Window = new TextWindow();
            Window.DisplayName = name;
        }
    }
}
