using CodsieOS.Apps;
using System.Collections.Generic;

namespace CodsieOS.Core
{
    static class AppManager
    {
        public static List<App> Applications = new List<App>();

        public static void AddNewApp(App app)
        {
            Applications.Add(app);
        }
    }
}
