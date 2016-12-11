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
        private long segment = 0;
        public static int baseSegment = 5;
        public Form1()
        {
            InitializeComponent();
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
            segment = barFractalHeight.Value / (segmentsLength(barIteration.Value));
            if (comboBoxFractalChoice.Text == "Кривая Коха")
            {
                InitTurtleKochCurve();
                DrawKochCurve(barIteration.Value);
            }
            if (comboBoxFractalChoice.Text == "Снежинка Коха")
            {
                segment /= 2;
                InitTurtleKochSnowFlake();
                DrawKochSnowFlake(barIteration.Value);
            }
        }
        




        public void InitTurtle()
        {
            Turtle.Delay = 1100 / barSpeed.Value;
            Turtle.Reset();
            Turtle.Init(pnCanvas);
            Turtle.ShowTurtle = false;
            Turtle.PenSize = barThickness.Value;
            Turtle.PenUp();
            // Turtle will look to the right
        }

        public void InitTurtleKochSnowFlake()
        {
            Turtle.MoveTo(-barFractalHeight.Value / 4, -barFractalHeight.Value / 4);
            Turtle.PenDown();
        }

        public void InitTurtleKochCurve()
        {
            Turtle.MoveTo(-barFractalHeight.Value / 2, 0);
            Turtle.Rotate(90);
            Turtle.PenDown();
        }

        public void DrawKochCurve(int n)
        {
            snowflakeOneSide(n);
        }

        public void DrawKochSnowFlake(int n)
        {
            for (int i = 0; i < 4; i++)
            {
                snowflakeOneSide(n);
                Turtle.Rotate(90);
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
    }
}