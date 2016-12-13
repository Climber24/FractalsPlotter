using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace FractalsPlotter
{
    public partial class Form1 : Form
    {
        private const int Level = 5;
        //Высота и ширина для отрисовки (http://grafika.me/node/294)
        private int _width;
        private int _height;
        // Bitmap для фрактала
        private Bitmap _fractal;
        // используем для отрисовки на PictureBox
        private Graphics _graph;

        private void DrawTriangle(int level, PointF top, PointF left, PointF right)
        {
            //проверяем, закончили ли мы построение
            if (level == 0)
            {
                PointF[] points = new PointF[3]
                {
                    top, right, left
                };
                //рисуем фиолетовый треугольник
                _graph.FillPolygon(Brushes.BlueViolet, points);
            }
            else
            {
                //вычисляем среднюю точку (http://grafika.me/node/294)
                var leftMid = MidPoint(top, left); //левая сторона
                var rightMid = MidPoint(top, right); //правая сторона
                var topMid = MidPoint(left, right); // основание
                //рекурсивно вызываем функцию для каждого и 3 треугольников
                DrawTriangle(level - 1, top, leftMid, rightMid);
                DrawTriangle(level - 1, leftMid, left, topMid);
                DrawTriangle(level - 1, rightMid, topMid, right);
            }
        }

        //функция вычисления координат средней точки
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

        private void DrawCarpet(int level, RectangleF carpet)
        {
            //проверяем, закончили ли мы построение (http://grafika.me/node/294)
            if (level == 0)
            {
                //Рисуем прямоугольник (http://grafika.me/node/294)
                _graph.FillRectangle(Brushes.OrangeRed, carpet);
            }
            else
            {
                // делим прямоугольник на 9 частей (http://grafika.me/node/294)
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;
                // (x1, y1) - координаты левой верхней вершины прямоугольника (http://grafika.me/node/294)
                // от нее будем отсчитывать остальные вершины маленьких прямоугольников
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height)); // левый 1(верхний) (http://grafika.me/node/294)
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height)); // средний 1
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height)); // правый 1
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height)); // левый 2
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height)); // правый 2
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height)); // левый 3
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height)); // средний 3
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height)); // правый 3
            }
        }


        private long segment = 0;
        public static int baseSegment = 5;
        public Form1()
        {
            InitializeComponent();
            //инициализируем ширину и высоту (http://grafika.me/node/294)
            _width = FractalPictureBox.Width;
            _height = FractalPictureBox.Height;
        }

        public long segmentsLength(int numb)
        {
            long res = 3;
            for (int i = numb; i > 1; i--)
                res *= 3;
            return res;
        }

        public void DrawFractal_Click(object sender, EventArgs e)
        {
            InitTurtle();
            segment = trackBarFractalHeight.Value / (segmentsLength(trackBarIteration.Value));
            if (comboBoxFractalChoice.Text == "Кривая Коха")
            {
                InitTurtleKochCurve();
                DrawKochCurve(trackBarIteration.Value);
            }
            if (comboBoxFractalChoice.Text == "Снежинка Коха")
            {
                segment /= 2;
                InitTurtleKochSnowFlake();
                DrawKochSnowFlake(trackBarIteration.Value);
            }

            if (comboBoxFractalChoice.Text == "Треугольник Серпинского")
            {
                //создаем Bitmap для треугольника
                _fractal = new Bitmap(_width, _height);
                // cоздаем новый объект Graphics из указанного Bitmap
                _graph = Graphics.FromImage(_fractal);
                //вершины треугольника
                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);
                //вызываем функцию отрисовки
                DrawTriangle(Level, topPoint, leftPoint, rightPoint);
                //отображаем получившийся фрактал
                FractalPictureBox.BackgroundImage = _fractal; 
            }

            if (comboBoxFractalChoice.Text == "Ковёр Серпинского")
            {
                //создаем Bitmap для прямоугольника
                _fractal = new Bitmap(_width, _height);
                // cоздаем новый объект Graphics из указанного Bitmap
                _graph = Graphics.FromImage(_fractal);
                //создаем прямоугольник и вызываем функцию отрисовки ковра
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                DrawCarpet(Level, carpet);
                //отображаем результат
                FractalPictureBox.BackgroundImage = _fractal;
            }

        }
        




        public void InitTurtle()
        {
            Turtle.Delay = 1100 / trackBarSpeed.Value;
            Turtle.Reset();
            Turtle.Init(pnCanvas);
            Turtle.ShowTurtle = false;
            Turtle.PenSize = trackBarThickness.Value;
            Turtle.PenUp();
            // Turtle will look to the right
        }

        public void InitTurtleKochSnowFlake()
        {
            Turtle.MoveTo(-trackBarFractalHeight.Value / 4, -trackBarFractalHeight.Value / 4);
            Turtle.PenDown();
        }

        public void InitTurtleKochCurve()
        {
            Turtle.MoveTo(-trackBarFractalHeight.Value / 2, 0);
            Turtle.Rotate(90);
            Turtle.PenDown();
        }

        public void DrawKochCurve(int n)
        {
            snowflakeOneSide(n);
        }

        public void DrawKochSnowFlake(int n)
        {
            for (int i = 0; i < trackBarSidesCount.Value; i++)
            {
                snowflakeOneSide(n);
                Turtle.Rotate(360 / trackBarSidesCount.Value);
            }
        }

        void snowflakeOneSide(int n)
        {
            if (n == 0)
            {
                Turtle.Forward(segment);
            }
            else
            {
                snowflakeOneSide(n - 1);
                Turtle.Rotate(-60);
                snowflakeOneSide(n - 1);
                Turtle.Rotate(120);
                snowflakeOneSide(n - 1);
                Turtle.Rotate(-60);
                snowflakeOneSide(n - 1);
            }
        }

        private void comboBoxFractalChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFractalChoice.Text == "Снежинка Коха")
            {
                trackBarSidesCount.Visible = true;
                labelSidesCount.Visible = true;
            }
            else
            {
                trackBarSidesCount.Visible = false;
                labelSidesCount.Visible = false;
            }
            if (comboBoxFractalChoice.Text == "Треугольник Серпинского" || 
                comboBoxFractalChoice.Text == "Ковёр Серпинского")
            {
                pnCanvas.Visible = false;
                FractalPictureBox.Visible = true;
            }
            else
            {
                pnCanvas.Visible = true;
                FractalPictureBox.Visible = false;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Романов С.С., репозиторий проекта: https://github.com/LaHesis/FractalsPlotter. Часть кода для построения треугольника и ковра Серпинского взяты из http://grafika.me/node/294", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}