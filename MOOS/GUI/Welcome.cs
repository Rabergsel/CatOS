#if HasGUI
using MOOS.FS;
using MOOS.Misc;
using System.Drawing;

namespace MOOS.GUI
{
    internal class Welcome : Window
    {
        public Image img;

        public Welcome(int X, int Y) : base(X, Y, 280, 225)
        {

            this.Title = "Welcome";

            img = new PNG(File.ReadAllBytes("Images/Banner.png"));
        }

        public override void OnDraw()
        {
            base.OnDraw();
            Framebuffer.Graphics.DrawImage(X, Y, img);
            WindowManager.font.DrawString(X, Y + img.Height, "Welcome to CatOS!\nThis project is based MOOS.\n\nThe aim is to provide a light-weight OS for all devices.\nCheck out:\nCatOS: https://github.com/Rabergsel/CatOS/\nMOOS: https://github.com/nifanfa/Moos!", Width);
        }
    }
}
#endif