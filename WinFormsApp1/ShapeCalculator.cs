using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ShapeCalculator : Form
    {
        private TextBox lengthInput;
        private TextBox breadthInput;
        private TextBox radiusInput;
        private TextBox sideInput;
        private TextBox baseInput;
        private TextBox heightInput;
        private Button calculateButton;
        private Label resultLabel;

        public ShapeCalculator()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Size = new System.Drawing.Size(400, 500);
            this.Text = "Shape Area Calculator";

            // Initialize controls for Rectangle
            Label rectLabel = new Label()
            {
                Text = "Rectangle",
                Location = new System.Drawing.Point(20, 20)
            };

            lengthInput = new TextBox()
            {
                Location = new System.Drawing.Point(20, 50),
                PlaceholderText = "Enter length"
            };

            breadthInput = new TextBox()
            {
                Location = new System.Drawing.Point(20, 80),
                PlaceholderText = "Enter breadth"
            };

            calculateButton = new Button()
            {
                Text = "Calculate",
                Location = new System.Drawing.Point(20, 300)
            };
            calculateButton.Click += CalculateButton_Click;

            resultLabel = new Label()
            {
                Location = new System.Drawing.Point(20, 350),
                AutoSize = true
            };

            this.Controls.AddRange(new Control[] {
            rectLabel, lengthInput, breadthInput,
            calculateButton, resultLabel
        });
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lengthInput.Text, out double length) &&
                double.TryParse(breadthInput.Text, out double breadth))
            {
                double area = CalculateRectangleArea(length, breadth);
                resultLabel.Text = $"Area of rectangle is: {area}";
            }
        }

        private double CalculateRectangleArea(double length, double breadth)
        {
            return length * breadth;
        }

        private double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private double CalculateSquareArea(double side)
        {
            return side * side;
        }

        private double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new ShapeCalculator());
        }
    }
}
