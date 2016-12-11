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
        public Form1()
        {
            InitializeComponent();
            Turtle.Init(pnKoch);
        }

        private void DrawKoch_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process 
            Turtle.Delay = 200;

            // Draw a equilateral triangle 
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle 
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 10;
            Koch.DrawSnowflake(2);
        }
    }

    class Koch
    {
        public static int segment = 5;
        public static void DrawSnowflake(int n)
        {
            Turtle.PenSize = 1;
            Turtle.MoveTo(0, 0);
            Turtle.PenDown();

            snowflakeOneSide(n);
            //Turtle.Rotate(120);
            //snowflakeOneSide(n);
        }

        static void snowflakeOneSide(int n)
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
