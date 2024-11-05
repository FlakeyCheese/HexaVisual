using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaVisual
{
    public partial class Form1 : Form
    {
        PointF[] polygonPoints = new PointF[7];
        Pen blackPen = new Pen(Color.Black, 5);
        int[,] hexa = { { -1, -1, 1 }, { 3, 5, -1 }, { 1, 6, -1 }, { 2, 4, -1 }, { 8, -1, -1 }, { 0, -1, -1 }, { 7, -1, -1 }, { -1, -1, 2 }, { -1, -1, 3 } };
        SolidBrush[] colours = { new SolidBrush(Color.Blue), new SolidBrush(Color.Red), new SolidBrush(Color.Blue), new SolidBrush(Color.Yellow), new SolidBrush(Color.Orange), new SolidBrush(Color.Pink), new SolidBrush(Color.Green), new SolidBrush(Color.Yellow), new SolidBrush(Color.Red) };
        int currentSide = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPolygon(colours[currentSide], polygonPoints);
            e.Graphics.DrawPolygon(blackPen, polygonPoints);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            label1.Text = Convert.ToString(currentSide);

            polygonPoints[0] = new PointF(400, 127);
            polygonPoints[1] = new PointF(200, 127);
            polygonPoints[2] = new PointF(100, 300);
            polygonPoints[3] = new PointF(200, 473);
            polygonPoints[4] = new PointF(400, 473);
            polygonPoints[5] = new PointF(500, 300);
            polygonPoints[6] = new PointF(400, 127);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hexa[currentSide, 0] != -1)
            {
                currentSide = hexa[currentSide, 0];
                label1.Text = Convert.ToString(currentSide);
                this.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hexa[currentSide, 1] != -1)
            {
                currentSide = hexa[currentSide, 1];
                label1.Text = Convert.ToString(currentSide);
                this.Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hexa[currentSide, 2] != -1)
            {
                currentSide = hexa[currentSide, 2];
                label1.Text = Convert.ToString(currentSide);
                this.Invalidate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
