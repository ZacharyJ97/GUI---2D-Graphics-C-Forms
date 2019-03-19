/*Copyright Zachary Fitzpatrick 2019
 * This program is made for academic pursuits in studying computer graphics and made completely with the C# Windows Forms and Drawing Libraries*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        private Point[] vertices = new Point[100];

        //This array is used to take a copy of exactly the amount of vertices the user creates since
        //C# fills the original array with (0,0) in extra, unused slots
        private Point[] completeVertices= new Point[100];

        //This array and its index is just used in the "movement" functions
        private Point[] moveVertices;
        private int moveIndex = 0;
        private int moveSpace = 2;

        //Pointer variables to go along with array and the count for each added vertex
        private int vertIndex = 0;
        private Point curVertex;
        private int vertCount;

        //Our graphics context
        private Graphics polygon;

        //Bool for deciding whether you want points on the picture and if you want them filled
        private bool drawPoint = true;
        private bool fillPoint = true;
        //Int control for brush size and vertex size
        public int vertexSize = 2;
        public static int lineSize = 2;

        //Bool determining if user wants to free paint and then the x and y coords temporarily set to -1
        private bool freePaint = false;
        private int freeX = -1;
        private int freeY = -1;

        //Variable for BG Color just used for custom ones
        Color backgroundColor;

        /*****************************/

        //The whole form, initializes other pieces as well
        public PolygonEditor()
        {
            InitializeComponent();
            //Prevents flickering when drawing/painting
            DoubleBuffered = true;
            //Creating our drawable graphics context
            polygon = Canvas.CreateGraphics();

            //Sets all the tooltips for the form
            CanvasStyleTip.SetToolTip(BackgroundCB, "Changing styles erases all free-drawn paint and fills, only user-made polygon lines will remain.");
            RedrawLinesTip.SetToolTip(RedrawLinesBtn, "Refills the current user-drawn lines with the selected color.");
            CustomColorTip.SetToolTip(LineColorPalBtn, "Create your own color for the lines/vertices.");
            CustomColorTip2.SetToolTip(FillColorPalBtn, "Create your own color for filling your shape.");
            FillShapeTip.SetToolTip(FillButton, "Fills the current polygonal area with the selected color.");
            NewShapeTip.SetToolTip(NewShapeBtn, "Deselects current polygon lines/vertices to allow drawing of a new shape.");
            CompleteForMeTip.SetToolTip(FillAllLinesBtn, "Draws the completed polygon using the user's lines with the selected color.");
            ResetCanvasTip.SetToolTip(ClearCanvasBtn, "Clears the canvas and resets the background to white.");
            PixelSpacingTip.SetToolTip(MoveSpaceScaler, "Sets the space width in number of pixels to move current user drawn lines.");
            /*************************************/


            //Setting default color for color previews
            LineColorDisplayBox.BackColor = userPen.Color;
            FillColorDisplayBox.BackColor = fillPen.Color;

            //Defaulting background to solid white if user does no specifically chose a color
            BackgroundCB.SelectedIndex = 0;
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
        private void NewShapeBtn_Click(object sender, EventArgs e)
        {
            Array.Clear(vertices, 0, vertices.Length);
            vertCount = 0;
            vertIndex = 0;
        }

        //Corresponds to Complete Polygon For Me Button, will draw over your lines with new color
        //and close the polygon with the last edge necessary
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
                //Fills canvas with white and the next line resets the combo box back to white
                polygon.Clear(Color.White);
                BackgroundCB.SelectedIndex = 0;
                
                //ifs prevent trying to clear a null array
                if (vertices != null)
                {
                    Array.Clear(vertices, 0, vertices.Length);
                }
                if (completeVertices != null)
                {
                    Array.Clear(completeVertices, 0, completeVertices.Length);
                }
                if (moveVertices != null)
                {
                    Array.Clear(moveVertices, 0, moveVertices.Length);
                }
                vertCount = 0;
                vertIndex = 0;
                //Last refresh over everything
                Canvas.Refresh();
            }
            //Need to remake the polygon graphics context to continue drawing again
            polygon = Canvas.CreateGraphics();
        }
        //A custom color palette for lines, both palette button methods show the dialog of color
        //and then link the chosen color to the appropriate pen, and check the corresponding RB
        private void LineColorPalBtn_Click(object sender, EventArgs e)
        {
            if (lineColorPalette.ShowDialog() == DialogResult.OK)
            {
                userPen.Color = lineColorPalette.Color;
                CustomColorLineRB.Checked = true;
                LineColorDisplayBox.BackColor = userPen.Color;
            }
        }

        //A custom color palette for filling the shape
        private void FillColorPalBtn_Click(object sender, EventArgs e)
        {
            if (fillColorPalette.ShowDialog() == DialogResult.OK)
            {
                fillPen.Color = fillColorPalette.Color;
                CustomColorFillRB.Checked = true;
                FillColorDisplayBox.BackColor = fillPen.Color;
            }
        }

        //Button corresponding to choosing a custom color for the background
        private void CustomBGColorBtn_Click(object sender, EventArgs e)
        {
            if (BGColorPalette.ShowDialog() == DialogResult.OK)
            {
                backgroundColor = BGColorPalette.Color;
            }
        }

        /*End of Button Code*/
        /**********************************/


        /*Below is Code other controls and selections ike checkboxes*/

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
        //Lot of code here because of the number of choices available and need to draw on
        //the canvas
        private void BackgroundCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //New graphics context is made and drawn over the canvas, separate from our polygon
            Graphics grid;
            grid = Canvas.CreateGraphics();
            Pen gridPen = new Pen(Color.Black, 1);
            DoubleBuffered = true;

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Solid White")
            {
                grid.Clear(Color.White);
            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Solid Black")
            {
                grid.Clear(Color.Black);
            }

            //Following if will draw a grid of lines, this code will be repeated several times with just changes
            //in grid size or color scheme
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

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Custom Color")
            {
               grid.Clear(backgroundColor);
            }

            if (BackgroundCB.Items[BackgroundCB.SelectedIndex].ToString() == "Custom Color w/ Small Grid")
            {
                    grid.Clear(backgroundColor);
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

            //Redraws your current lines over background changes, not previous shapes
            if (vertCount > 1)
            {
                polygon.DrawLines(userPen, completeVertices);
            }

        }

        /*End of selection and other controls function area*/
        /**************************************************/

        /*Functions for Polygon Drawing and then Free Drawing */

        //Method that takes in mouse arguments for clicking 
        //and then draws the graphics accordingly. Main drawing method
        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && vertIndex <= vertices.Length - 1 && freePaint == false)
            {
                //Storing the Mouse's position on the canvas into a new Point object then add to my list of vertices
                curVertex = new Point(e.X, e.Y);
                vertices[vertIndex] = curVertex;

                //Following if-else just checks if we want to draw points and also fill them
                if (drawPoint == true && fillPoint == true)
                {
                    //Draw a point centered at that click location
                    polygon.FillRectangle(userPen.Brush, curVertex.X - (vertexSize / 2), curVertex.Y - (vertexSize / 2), vertexSize, vertexSize);
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
                //a new array that is used in other functions. Otherwise, empty array slots fill in (0,0) and draw lines to that location
                completeVertices = new Point[vertCount];
                Array.Copy(vertices, completeVertices, vertCount);
            }
        }

        //Free draw with right mouse down
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                freePaint = true;
                freeX = e.X;
                freeY = e.Y;
            }
        }

        //tracking free drawing movement from right mouse button held down
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (freePaint)
            {

                polygon.DrawLine(userPen, freeX, freeY, e.X, e.Y);

            }
            freeX = e.X;
            freeY = e.Y;
        }
        //Turns off free drawing when mouse is up
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            freePaint = false;
        }
        /***********************************/

        //Remainder of code is all the Radio Button functions to 
        //change colors of the line or fill and also the preview box colors
        private void RedRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Red, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void GreenRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Green, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void BlueRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Blue, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void YellowRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Yellow, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void BlackRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Black, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void whiteRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.White, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void FillRedRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Red, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillGreenRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Green, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillBlueRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Blue, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillYellowRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Yellow, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillBlackRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Black, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillWhiteRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.White, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void PurpleRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Purple, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void OrangeRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Orange, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void PinkRB_CheckedChanged(object sender, EventArgs e)
        {
            userPen = new Pen(Color.Pink, lineSize);
            LineColorDisplayBox.BackColor = userPen.Color;
        }

        private void FillPurpleRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Purple, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillOrangeRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Orange, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void FillPinkRB_CheckedChanged(object sender, EventArgs e)
        {
            fillPen = new Pen(Color.Pink, lineSize);
            FillColorDisplayBox.BackColor = fillPen.Color;
        }

        private void CustomColorFillRB_CheckedChanged(object sender, EventArgs e)
        {
            if (!fillColorPalette.Color.IsEmpty)
            {
                fillPen.Color = fillColorPalette.Color;
                FillColorDisplayBox.BackColor = fillPen.Color;
            }
            

        }

        private void CustomColorLineRB_CheckedChanged(object sender, EventArgs e)
        {
            if (!lineColorPalette.Color.IsEmpty)
            {
                userPen.Color = lineColorPalette.Color;
                LineColorDisplayBox.BackColor = userPen.Color;
            }
            
        }

        private void ArrowUpBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 0)
            {
                moveVertices = completeVertices;
                foreach (Point p in moveVertices)
                {
                    Point pMove = new Point(p.X, p.Y - moveSpace);
                    moveVertices[moveIndex] = pMove;
                    moveIndex++;
                }
                Array.Copy(moveVertices,0, completeVertices, 0, moveVertices.Length);
                BackgroundCB_SelectedIndexChanged(BackgroundCB, null);

                polygon.DrawLines(userPen, completeVertices);
            }
            moveIndex = 0;
        }

        private void ArrowLeftBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 0)
            {
                moveVertices = completeVertices;
                foreach (Point p in moveVertices)
                {
                    Point pMove = new Point(p.X - moveSpace, p.Y);
                    moveVertices[moveIndex] = pMove;
                    moveIndex++;
                }
                Array.Copy(moveVertices, 0, completeVertices, 0, moveVertices.Length);
                BackgroundCB_SelectedIndexChanged(BackgroundCB, null);

                polygon.DrawLines(userPen, completeVertices);
            }
            moveIndex = 0;
        }

        private void ArrowDownBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 0)
            {
                moveVertices = completeVertices;
                foreach (Point p in moveVertices)
                {
                    Point pMove = new Point(p.X, p.Y + moveSpace);
                    moveVertices[moveIndex] = pMove;
                    moveIndex++;
                }
                Array.Copy(moveVertices, 0, completeVertices, 0, moveVertices.Length);
                BackgroundCB_SelectedIndexChanged(BackgroundCB, null);
                polygon.DrawLines(userPen, completeVertices);
            }
            moveIndex = 0;
        }

        private void ArrowRightBtn_Click(object sender, EventArgs e)
        {
            if (vertCount > 0)
            {
                moveVertices = completeVertices;
                foreach (Point p in moveVertices)
                {
                    Point pMove = new Point(p.X + moveSpace, p.Y);
                    moveVertices[moveIndex] = pMove;
                    moveIndex++;
                }
                Array.Copy(moveVertices, 0, completeVertices, 0, moveVertices.Length);
                BackgroundCB_SelectedIndexChanged(BackgroundCB, null);

                polygon.DrawLines(userPen, completeVertices);
            }
            moveIndex = 0;
        }

        private void MoveSpaceScaler_ValueChanged(object sender, EventArgs e)
        {
            if (MoveSpaceScaler.Value >= 1)
            {
                moveSpace = (int) MoveSpaceScaler.Value;
            }
        }

        private void PolygonEditor_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        public Panel GetCanvas()
        {
            return Canvas;
        }

        public ComboBox GetBackgroundCB()
        {
            return BackgroundCB;
        }

    }
}
