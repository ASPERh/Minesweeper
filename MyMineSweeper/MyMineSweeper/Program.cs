using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using System.Net.Http.Headers;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MyMineSweeper
{
    internal class Program
    {
        static Music m = new Music("orchestral.ogg");
        static List<RectangleShape> c = new List<RectangleShape>();

        static void Main(string[] args)
        {
            RenderWindow w = new RenderWindow(new VideoMode(400, 400), "Game");
            w.Closed += W_Closed;
            c.Add(new RectangleShape(new Vector2f(50f, 50f)));
            c.Add(new RectangleShape(new Vector2f(50f, 50f)));
            foreach (RectangleShape r in c)
            {
                r.FillColor = Color.Blue;
                r.OutlineThickness = 2;
                r.OutlineColor = Color.Red;
            }


            w.MouseButtonPressed += W_MouseButtonPressed;
            while (w.IsOpen)
            {

                w.DispatchEvents();
                foreach (RectangleShape r in c)
                {
                    w.Draw(r);
                }

                w.Display();
            }
        }

        private static void W_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {

            if (e.Button == Mouse.Button.Left)
            {
                m.Play();
            }
            else
            {
                m.Stop();
            }
        }

        private static void W_Closed(object sender, EventArgs e)
        {
            Window w = (Window)sender;
            w.Close();
        }
    }
}
