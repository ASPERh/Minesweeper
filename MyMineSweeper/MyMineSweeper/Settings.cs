using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;

namespace MyMineSweeper
{
    public sealed class Settings
    {
        private int _numMines = 5;
        private int _numRows = 10;
        private int _numColuns = 10;
        private bool _isCancel = false;
        private RectangleShape buttonOKShape = new RectangleShape(new Vector2f(50, 30));
        private RectangleShape buttonCancelShape = new RectangleShape(new Vector2f(60, 30));

        private RectangleShape buttonUpNM = new RectangleShape(new Vector2f(5, 5));
        private RectangleShape buttonLowNM = new RectangleShape(new Vector2f(5, 5));

        private RectangleShape buttonUpNR = new RectangleShape(new Vector2f(5, 5));
        private RectangleShape buttonLowNR = new RectangleShape(new Vector2f(5, 5));

        private RectangleShape buttonUpNC = new RectangleShape(new Vector2f(5, 5));
        private RectangleShape buttonLowNC = new RectangleShape(new Vector2f(5, 5));

        public Settings() { }
        private static Settings _instance;

        public int NumMines { get => _numMines; set => _numMines = value; }
        public int NumRows { get => _numRows; set => _numRows = value; }
        public int NumColuns { get => _numColuns; set => _numColuns = value; }

        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }
        public bool showNewGame()
        {
            Font font = new Font("arial.ttf");

            RenderWindow w = new RenderWindow(new VideoMode(300, 250), "New Game", Styles.Close);
            RectangleShape mainShape = new RectangleShape(new Vector2f(300, 250));
            mainShape.FillColor = Color.White;
            mainShape.OutlineThickness = 1;
            mainShape.OutlineColor = Color.Black;


            buttonOKShape.FillColor = Color.White;
            buttonOKShape.OutlineThickness = 2;
            buttonOKShape.OutlineColor = Color.Black;
            buttonOKShape.Position = new Vector2f(150, 200);

            Text textOK = new Text("OK", font);
            textOK.FillColor = Color.Black;
            textOK.Position = new Vector2f(155, 202);
            textOK.CharacterSize = 18;


            buttonCancelShape.FillColor = Color.White;
            buttonCancelShape.OutlineThickness = 2;
            buttonCancelShape.OutlineColor = Color.Black;
            buttonCancelShape.Position = new Vector2f(220, 200);

            Text textCancel = new Text("Cancel", font);
            textCancel.FillColor = Color.Black;
            textCancel.Position = new Vector2f(222, 202);
            textCancel.CharacterSize = 18;


            Text textNumMines = new Text("Number of Mines:", font);
            textNumMines.FillColor = Color.Black;
            textNumMines.Position = new Vector2f(30, 130);
            textNumMines.CharacterSize = 18;

            Text textNumColums = new Text("Colums number:", font);
            textNumColums.FillColor = Color.Black;
            textNumColums.Position = new Vector2f(30, 80);
            textNumColums.CharacterSize = 18;

            Text textNumRows = new Text("Rows number:", font);
            textNumRows.FillColor = Color.Black;
            textNumRows.Position = new Vector2f(30, 30);
            textNumRows.CharacterSize = 18;
            Text textNumMines2 = new Text(_numMines.ToString(), font);
            textNumMines2.FillColor = Color.Black;
            textNumMines2.Position = new Vector2f(180, 130);
            textNumMines2.CharacterSize = 18;

            Text textNumColums2 = new Text(_numColuns.ToString(), font);
            textNumColums2.FillColor = Color.Black;
            textNumColums2.Position = new Vector2f(180, 80);
            textNumColums2.CharacterSize = 18;

            Text textNumRows2 = new Text(_numRows.ToString(), font);
            textNumRows2.FillColor = Color.Black;
            textNumRows2.Position = new Vector2f(180, 30);
            textNumRows2.CharacterSize = 18;

            buttonUpNM.FillColor = Color.White;
            buttonUpNM.OutlineThickness = 2;
            buttonUpNM.OutlineColor = Color.Black;
            buttonUpNM.Position = new Vector2f(210, 132);

            buttonLowNM.FillColor = Color.White;
            buttonLowNM.OutlineThickness = 2;
            buttonLowNM.OutlineColor = Color.Black;
            buttonLowNM.Position = new Vector2f(210, 142);

            buttonUpNR.FillColor = Color.White;
            buttonUpNR.OutlineThickness = 2;
            buttonUpNR.OutlineColor = Color.Black;
            buttonUpNR.Position = new Vector2f(210, 32);

            buttonLowNR.FillColor = Color.White;
            buttonLowNR.OutlineThickness = 2;
            buttonLowNR.OutlineColor = Color.Black;
            buttonLowNR.Position = new Vector2f(210, 42);



            buttonUpNC.FillColor = Color.White;
            buttonUpNC.OutlineThickness = 2;
            buttonUpNC.OutlineColor = Color.Black;
            buttonUpNC.Position = new Vector2f(210, 82);

            buttonLowNC.FillColor = Color.White;
            buttonLowNC.OutlineThickness = 2;
            buttonLowNC.OutlineColor = Color.Black;
            buttonLowNC.Position = new Vector2f(210, 92);



            w.Closed += W_Closed;
            w.MouseButtonPressed += W_MouseButtonPressed;
            while (w.IsOpen)
            {
                w.Clear();
                w.DispatchEvents();

                textNumRows2.DisplayedString = _numRows.ToString();
                textNumColums2.DisplayedString = _numColuns.ToString();
                textNumMines2.DisplayedString = _numMines.ToString();

                w.DispatchEvents();
                w.Draw(mainShape);
                w.Draw(buttonOKShape);
                w.Draw(textOK);
                w.Draw(buttonCancelShape);
                w.Draw(textCancel);
                w.Draw(textNumMines);
                w.Draw(textNumColums);
                w.Draw(textNumRows);
                w.Draw(textNumMines2);
                w.Draw(textNumColums2);
                w.Draw(textNumRows2);

                w.Draw(buttonUpNM);
                w.Draw(buttonLowNM);
                w.Draw(buttonUpNR);
                w.Draw(buttonLowNR);
                w.Draw(buttonUpNC);
                w.Draw(buttonLowNC);
                w.Display();

            }
            return _isCancel;
        }

        private void W_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            Window w = (Window)sender;
            if (checkContent(buttonOKShape, e))
            {
                _isCancel = true;
                w.Close();
            }

            if (checkContent(buttonCancelShape, e))
                w.Close();

            if (checkContent(buttonUpNR, e))
                _numRows++;
            if (checkContent(buttonLowNR, e))
                _numRows--;

            if (checkContent(buttonUpNC, e))
                _numColuns++;
            if (checkContent(buttonLowNC, e))
                _numColuns--;

            if (checkContent(buttonUpNM, e))
                _numMines++;
            if (checkContent(buttonLowNM, e))
                _numMines--;

        }

        private void W_Closed(object sender, EventArgs e)
        {
            Window w = (Window)sender;
            w.Close();
        }
        private bool checkContent(RectangleShape s, MouseButtonEventArgs e)
        {
            if (s.GetGlobalBounds().Contains(new Vector2f(e.X, e.Y)))
                return true;
            return false;
        }
    }

}
