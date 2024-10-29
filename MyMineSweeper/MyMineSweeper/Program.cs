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
using System.Runtime;

namespace MyMineSweeper
{
    internal class Program
    {
        static Music m = new Music("orchestral.ogg");
        static List<RectangleShape> cc = new List<RectangleShape>();
        static RectangleShape selShape;
        static void Main(string[] args)
        {

            Settings settings = Settings.GetInstance();
            if (!settings.showNewGame())
                return;
            int row = settings.NumRows;
            int col = settings.NumColuns;
            int mines = settings.NumMines;
            int size = 20;
            uint rui = (uint)(row * size);
            uint cui = (uint)(col * size);


            RenderWindow w = new RenderWindow(new VideoMode(rui, cui), "Game", Styles.Close);
            w.Closed += W_Closed;
            RectangleShape template = new RectangleShape(new Vector2f(20f, 20f));
            template.FillColor = Color.Blue;
            template.OutlineThickness = 1;
            template.OutlineColor = Color.White;

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    RectangleShape rs = new RectangleShape(template);
                    rs.Position = new Vector2f(20f * r, 20f * c);
                    cc.Add(rs);
                }
            }



            w.MouseButtonPressed += W_MouseButtonPressed;
            w.MouseEntered += W_MouseEntered; ;
            while (w.IsOpen)
            {
                w.Clear();
                w.DispatchEvents();
                foreach (RectangleShape r in cc)
                {
                    w.Draw(r);
                }

                w.Display();
            }
        }

        private static void W_MouseEntered(object sender, EventArgs e)
        {
            Window w = (Window)sender;

            foreach (RectangleShape r in cc)
            {

                if (r.GetGlobalBounds().Contains(new Vector2f(Mouse.GetPosition().X, Mouse.GetPosition().Y)))
                {
                    r.FillColor = Color.Yellow;
                }
            }

        }
        private static void W_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            foreach (RectangleShape r in cc)
            {
                if (r.GetGlobalBounds().Contains(new Vector2f(e.X, e.Y)))
                {
                    if (Mouse.IsButtonPressed(Mouse.Button.Left) && Mouse.IsButtonPressed(Mouse.Button.Right))
                    {
                        r.FillColor = Color.Yellow;

                    }
                    else if (e.Button == Mouse.Button.Left)
                    {
                        r.FillColor = Color.Cyan;
                    }
                    else if (e.Button == Mouse.Button.Right)
                    {
                        r.FillColor = Color.Red;
                    }

                }
            }


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
