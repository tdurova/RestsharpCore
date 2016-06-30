using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestsharpCore.appmanager
{
    public class ApplicationManager
    {
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                //newInstance.Navigator.GoToHomePage();
                app.Value = newInstance;

            }
            return app.Value;
        }
    }
}
