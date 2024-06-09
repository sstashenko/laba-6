using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public interface IShape
        {
            double GetArea();
        }

        public class Rectangle : IShape
        {
            public double A { get; set; }
            public double B { get; set; }

            public Rectangle(double a, double b)
            {
                A = a;
                B = b;
            }

            public double GetArea()
            {
                return A * B;
            }
        }

        public class Triangle : IShape
        {
            public double C { get; set; }
            public double D { get; set; }

            public Triangle(double c, double d)
            {
                C = c;
                D = d;
            }

            public double GetArea()
            {
                return 0.5 * C * D;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonCalculateRectangleArea_Click(object sender, EventArgs e)
        {
        }

        private void buttonCalculateTriangleArea_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculateRectangleArea_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);

                Rectangle rectangle = new Rectangle(a, b);
                double area = rectangle.GetArea();
                textBoxRectangleArea.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for A and B.");
            }
        }

        private void buttonCalculateTriangleArea_Click_1(object sender, EventArgs e)
        {
            try
            {
                double c = Convert.ToDouble(textBoxC.Text);
                double d = Convert.ToDouble(textBoxD.Text);

                Triangle triangle = new Triangle(c, d);
                double area = triangle.GetArea();
                textBoxTriangleArea.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for C and D.");
            }
        }
    }
}
