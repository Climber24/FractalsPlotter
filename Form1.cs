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
        }
    }
}