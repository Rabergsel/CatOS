#if HasGUI
using MOOS.FS;
using MOOS.Misc;
using System.Collections.Generic;
using System.Drawing;

namespace MOOS.GUI
{
    internal static class WindowManager
    {
        public static List<Window> Windows;
        public static IFont font;
        public static Image CloseButton;

        public static void Initialize()
        {
            Windows = new List<Window>();
            CloseButton = new PNG(File.ReadAllBytes("Images/Close.png"));


            PNG yehei = new PNG(File.ReadAllBytes("Images/M+.png"));
            font = new IFont(yehei, "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~", 18);

            MouseHandled = false;
        }

        public static void MoveToEnd(Window window)
        {
            Windows.Insert(0, window, true);
        }

        public static void DrawAll()
        {
            for (int i = Windows.Count - 1; i >= 0; i--)
            {
                if (Windows[i].Visible)
                    Windows[i].OnDraw();
            }
        }

        public static void InputAll()
        {
            for (int i = 0; i < Windows.Count; i++)
            {
                if (Windows[i].Visible)
                    Windows[i].OnInput();
            }
        }

        public static bool HasWindowMoving = false;

        public static bool MouseHandled
        {
            get => HasWindowMoving;
            set => HasWindowMoving = value;
        }

    }
}
#endif