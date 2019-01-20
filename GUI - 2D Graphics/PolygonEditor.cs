using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GUI___2D_Graphics
{
    public partial class PolygonEditor : Form
    {
        /***************Declarations*********/

        //Default user Pen for drawing, and then filling the shape
        public Pen userPen = new Pen(Color.Black, lineSize);
        public Pen fillPen = new Pen(Color.Black, lineSize);

        //Array to store polygon vertices, Lists would be preferrable, but draw methods
        //are built to take in arrays, and conversion had unintended side effects
        private Point[] vertices = new Point[40];

        //This array is used to take a copy of exactly the amount of vertices the user creates since
        //C# fills the original array with (0,0) in extra, unused slots
        private Point[] completeVertices;

        //Pointer variables to go along with array and the count for each added vertex
        private int vertIndex = 0;
        private Point curVertex;
        private int vertCount;

        //Our graphics context
        private Graphics polygon;

        //Bool for deciding whether you want points on the picture and if you want them filled
        bool drawPoint = true;
        bool fillPoint = true;
        //Int control for brush size and vertex size
        public int vertexSize = 2;
        public static int lineSize = 2;

        /*****************************/

        //The whole form
        public PolygonEditor()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        //On the Editor's load, nothing extra necessary
        private void PolygonEditor_Load(object sender, EventArgs e)
        {

        }

        //Handles the fact that we are painting only on the canvas
        private void Canvas_OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        /*End of Window Base Code*/
        /***************************/

        /*Below are all the methods for visible buttons*/
         
        //Method to complete the polygon by filling it; it will then reset our array collecting vertices
        //along with its pointer and vertex count
        private void FillBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 2)
            {
                polygon.FillPolygon(fillPen.Brush, completeVertices);
            }

        }

        /*This is actually the New Shape button, user is marking their current polygon 
         "complete" and moving onto a new one*/
        private void completeShapeBtn_Click(object sender, EventArgs e)
        {
            Array.Clear(vertices, 0, vertices.Length);
            vertCount = 0;
            vertIndex = 0;
        }

        //Corresponds to Complete Polygon For Me Button
        private void FillAllLinesBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 0)
            {
                polygon.DrawPolygon(userPen, completeVertices);
            }

        }

        //Redraws Lines for you
        private void RedrawLinesBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 1)
            {
                polygon.DrawLines(userPen, completeVertices);
            }
        }

        //Clears the entire canvas of graphics and resets it to white
        private void ClearCanvasBtn_Click(object sender, EventArgs e)
        {
            if (polygon != null && vertCount > 0)
            {
                polygon.Clear(Color.White);
                BackgroundCB.Text = "Select a Background Style";
                polygon.Dispose();
                Array.Clear(vertices, 0, vertices.Length);
                vertCount = 0;
                vertIndex = 0;
            }

        }
        /*End of Button Code*/
        /**********************************/

        //Method that takes in mouse arguments for clicking and then draws the graphics accordingly
        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            polygon = Canvas.CreateGraphics();
            if (e.Button == MouseButtons.Left && vertIndex <= vertices.Length - 1)
            {
                //Storing the Mouse's position on the canvas into a new Point object then add to my list of vertices
                curVertex = new Point(e.X, e.Y);
                vertices[vertIndex] = curVertex;

                //Following if-else just checks if we want to draw points and also fill them
                if (drawPoint == true && fillPoint == true)
                {
                    //Draw a point centered at that click location
                    polygon.FillRectangle(userPen.Brush, (float)(curVertex.X - (vertexSize/2)),(float)(curVertex.Y - (vertexSize / 2)), (int)vertexSize, (int)vertexSize);
                }
                else if (drawPoint == true && fillPoint == false)
                {
                    //Draw a point centered at that click location
                    polygon.DrawRectangle(userPen, (float)(curVertex.X - (vertexSize / 2)), (float)(curVertex.Y - (vertexSize / 2)), (int)vertexSize, (int)vertexSize);
                }
                vertCount++;

                //As long as we have more than one point, draw a line from the previous point, to the current
                if (vertCount > 1)
                {
                    polygon.DrawLine(userPen, vertices.ElementAt(vertIndex - 1), curVertex);
                }
                vertIndex++;
                //Everytime we get a new point, I copy the current list of vertices, exactly as they are, to 
                //a new array that is used in other functions. Otherwise, empty array slots fill in (0,0)
                completeVertices = new Point[vertCount];
                Array.Copy(vertices, completeVertices, vertCount);
            }
        }

        //Checkbox to control vertex drawing
        private void DrawVertex_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawVertex.Checked)
            {
                drawPoint = true;
            }
            else
            {
                drawPoint = false;
            }
        }

        //Checkbox to control vertex filling
        private void FillVertex_CheckedChanged(object sender, EventArgs e)
        {
            if (FillVertex.Checked)
            {
                fillPoint = true;
            }
            else
            {
                fillPoint = false;
            }
        }

        //Size Controls for the vertex
        private void VertexSizeScaler_ValueChanged(object sender, EventArgs e)
        {
            if (VertexSizeScaler.Value != 0)
            {
                vertexSize = (int)VertexSizeScaler.Value;
            }
        }
        //Size Controls for the line width
        private void LineSizeScaler_ValueChanged(object sender, EventArgs e)
        {
            if (LineSizeScaler.Value >= 1)
            {
                lineSize = (int)LineSizeScaler.Value;
                userPen.Width = lineSize;
            }
        }

        //Combo Box Controls for the Background Changer and what happens for each option
        private void BackgroundCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics grid;
            grid = Canvas.CreateGraphics();
            Pen gridPen = new Pen(Color.Black, 1);

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Solid White")
            {
                grid.Clear(Color.White);
            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Solid Black")
            {
                grid.Clear(Color.Black);
            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Small Grid on White")
            {
                grid.Clear(Color.White);
                gridPen.Color = Color.LightGray;
                gridPen.Width = 1;
                int numCells = 200;
                int cellSize = 10;
                //Logic for drawing a grid from: https://stackoverflow.com/questions/2753519/efficiently-draw-a-grid-in-windows-forms
                for (int y = 0; y < numCells; ++y)
                {
                    grid.DrawLine(gridPen, 0, y * cellSize, numCells * cellSize, y * cellSize);
                }

                for (int x = 0; x < numCells; ++x)
                {
                    grid.DrawLine(gridPen, x * cellSize, 0, x * cellSize, numCells * cellSize);
                }

            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Small Grid on Black")
            {
                grid.Clear(Color.Black);
                gridPen.Color = Color.LightGray;
                gridPen.Width = 1;
                int numCells = 200;
                int cellSize = 10;
                //Logic for drawing a grid from: https://stackoverflow.com/questions/2753519/efficiently-draw-a-grid-in-windows-forms
                for (int y = 0; y < numCells; ++y)
                {
                    grid.DrawLine(gridPen, 0, y * cellSize, numCells * cellSize, y * cellSize);
                }

                for (int x = 0; x < numCells; ++x)
                {
                    grid.DrawLine(gridPen, x * cellSize, 0, x * cellSize, numCells * cellSize);
                }

            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Large Grid on White")
            {
                grid.Clear(Color.White);
                gridPen.Color = Color.LightGray;
                gridPen.Width = 1;
                int numCells = 200;
                int cellSize = 20;
                //Logic for drawing a grid from: https://stackoverflow.com/questions/2753519/efficiently-draw-a-grid-in-windows-forms
                for (int y = 0; y < numCells; ++y)
                {
                    grid.DrawLine(gridPen, 0, y * cellSize, numCells * cellSize, y * cellSize);
                }

                for (int x = 0; x < numCells; ++x)
                {
                    grid.DrawLine(gridPen, x * cellSize, 0, x * cellSize, numCells * cellSize);
                }

            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Large Grid on Black")
            {
                grid.Clear(Color.Black);
                gridPen.Color = Color.LightGray;
                gridPen.Width = 1;
                int numCells = 200;
                int cellSize = 20;
                //Logic for drawing a grid from: https://stackoverflow.com/questions/2753519/efficiently-draw-a-grid-in-windows-forms
                for (int y = 0; y < numCells; ++y)
                {
                    grid.DrawLine(gridPen, 0, y * cellSize, numCells * cellSize, y * cellSize);
                }

                for (int x = 0; x < numCells; ++x)
                {
                    grid.DrawLine(gridPen, x * cellSize, 0, x * cellSize, numCells * cellSize);
                }

            }

            //Redrawing lines over background changes
            if (vertCount > 1)
            {
                polygon.DrawLines(userPen, completeVertices);
            }

        }


        //Below are all the Radio Button functions to change colors of the line or fill
        private void RedRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Red, lineSize);
        }

        private void GreenRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Green, lineSize);
        }

        private void BlueRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Blue, lineSize);
        }

        private void YellowRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Yellow, lineSize);
        }

        private void BlackRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Black, lineSize);
        }

        private void whiteRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.White, lineSize);
        }

        private void FillRedRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Red, lineSize);
        }

        private void FillGreenRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Green, lineSize);
        }

        private void FillBlueRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Blue, lineSize);
        }

        private void FillYellowRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Yellow, lineSize);
        }

        private void FillBlackRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Black, lineSize);
        }

        private void FillWhiteRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.White, lineSize);
        }

        private void PurpleRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Purple, lineSize);
        }

        private void OrangeRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Orange, lineSize);
        }

        private void PinkRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Pink, lineSize);
        }

        private void FillPurpleRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Purple, lineSize);
        }

        private void FillOrangeRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Orange, lineSize);
        }

        private void FillPinkRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Pink, lineSize);
        }
    }
}
