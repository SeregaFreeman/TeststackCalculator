﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace TestStackFramework.framework
{
    public class MyApp
    {
        public Application Application { get; set; }
        public static Window Window { get; set; }

        public MyApp(Application app, Window window)
        {
            Application = app;
            Window = window;
        }

        public static MyApp Launch()
        {
            var app = Application.Launch(Path.Combine(Settings.Default.Path, Settings.Default.EXE));
            var window = app.GetWindows().FirstOrDefault();
            return new MyApp(app, window);
        }

        public void Kill()
        {
            Application.Kill();
        }
    }
}
