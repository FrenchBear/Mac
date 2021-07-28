using System;
using Gtk;

namespace GTKFirst
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win1 = new MainWindow();
            win1.Show();
            FixedWindow win2 = new FixedWindow();
            win2.Show();
            AlignmentWindow win3 = new AlignmentWindow();
            win3.Show();
            Application.Run();
        }
    }
}
