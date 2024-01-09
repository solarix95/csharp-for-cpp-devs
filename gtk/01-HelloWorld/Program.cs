﻿using Gdk;
using Gtk;

class MyWindow : Gtk.Window {
    public MyWindow() : base("hello, world") {
    }

    protected override bool OnDeleteEvent(Event e) {
        Application.Quit();
        return true;
    }
}

class Hello {
    static void Main() {
        Application.Init();
        MyWindow w = new MyWindow();
        w.ShowAll();
        Application.Run();
    }
}