using System;
using Gtk;

namespace GTKFirst
{
    public partial class FixedWindow : Gtk.Window
    {
        public FixedWindow() : base("fixed") // base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            SetDefaultSize(300, 280);
            SetPosition(WindowPosition.Center);
            ModifyBg(StateType.Normal, new Gdk.Color(40, 40, 40));
            DeleteEvent += delegate { Application.Quit(); };

            Gdk.Pixbuf bardejov=null, rotunda=null, mincol=null;

            try
            {
                bardejov = new Gdk.Pixbuf("images/layout/bardejov.jpg");
                rotunda = new Gdk.Pixbuf("images/layout/rotunda.jpg");
                mincol = new Gdk.Pixbuf("images/layout/mincol.jpg");
            }
            catch
            {
                Console.WriteLine("Images not found");
                Environment.Exit(1);
            }

            Image image1 = new Image(bardejov);
            Image image2 = new Image(rotunda);
            Image image3 = new Image(mincol);


            Fixed fix = new Fixed();

            fix.Put(image1, 20, 20);
            fix.Put(image2, 40, 160);
            fix.Put(image3, 170, 50);

            Add(fix);
            ShowAll();
        }
    }
}
