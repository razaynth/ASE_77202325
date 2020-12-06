using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Assessment
{

    /// <summary>
    /// Class canvass to use many aspects to draw something on panel basically for 
    /// creating different shapes and modifying them
    /// </summary>
    class Canvass
    {
        //creating graphics which is use to make some shapes 
        Graphics g;

        /// <summary>
        /// usign default pen with color black and width =2
        /// </summary>
        Pen p = new Pen(Color.Black, 2);
        /// <summary>
        /// A solid brush to fill shapes
        /// </summary>
        SolidBrush brush;
        
        /// <summary>
        /// check whether user want to fill color or not
        /// </summary>
        bool fil = false;
        /// <summary>
        /// Declaring xpositon and y position for pen positioning in the bitmap 
        /// </summary>
        public int Xpos;
        public int Ypos;

        // <summary>
        /// Default constructor
        /// </summary>
        /// <param name="g">Graphics to draw shapes on bitmap
        /// </param>
        

        public Canvass(Graphics g)
        {
            this.g = g;
            //initializing positions to zero to have something to start with
            this.Xpos = 0;
            this.Ypos = 0;

        }
        /// <summary>
        /// Fill shape method used to fill colors in shape if called
        /// </summary>
        /// <param name="color">Input colors { Red, Green, Blue}</param>

        public void fillShape(string color)
        {
            //turning fil to true whenever using inside this method
            fil = true;

            fil = true;
            //checking if color provided as parameter is red , green or blue
            if (color == "green")
            {
                brush = new SolidBrush(Color.Green);

            }

            else if (color == "red")
            {
                brush = new SolidBrush(Color.Red);

            }
            else if (color == "blue")
            {
                brush = new SolidBrush(Color.Blue);

            }
        }

        
        public void fillred()
        {
            brush = new SolidBrush(Color.Red);
        }
        /// <summary>
        /// Pen method created to decide whether to have a coloured pen or not
        /// </summary>
        /// <param name="fill">Fill is variable used to declare which color user wants to use</param>
        public void pen(String fill)
        {
            //Changing the input fill to lower case
            fill = fill.ToLower();
            //If statements to decide whether to create a pen of red , blue or green
            if (fill == "red")
            {
                p = new Pen(Color.Red, 2);
            }
            else if (fill == "blue")
            {
                p = new Pen(Color.Blue, 2);
            }
            else if (fill == "green")
            {
                p = new Pen(Color.Green, 2);
            }

        }
        /// <summary>
        /// Move to method is used to initialize the position of x and y positions
        /// </summary>
        /// <param name="xpos">X-axis value</param>
        /// <param name="xpos">Y-axis value</param>
        public void moveto(int xpos, int ypos)
        {
            this.Xpos = xpos;
            this.Xpos = ypos;

        }
        /// <summary>
        /// Draw to method is used to create a line from point x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void DrawTo(int x, int y)
        {
            g.DrawLine(p, Xpos, Ypos, x, y);

            this.Xpos = x;
            this.Ypos = y;
        }
        /// <summary>
        /// Draw Rectangle is method used to create rectangle
        /// </summary>
        /// <param name="height">Height of rectangle</param>
        /// <param name="width">Width of recatangle</param>
        public void DrawRectangle(int height, int width)
        {

            g.DrawRectangle(p, Xpos, Ypos, width, height);

            if (fil)
            {
                //if condition to know whether to fill shape or not
                if (fil)
                    g.FillRectangle(brush, Xpos, Ypos, width, height);
            }

        }

        /// <summary>
        /// Draw circle is method used to create an ellipse
        /// </summary>
        /// <param name="diameter">Diameter of ellipse</param>
        /// <param name="width">Width of ellipse</param>
        public void DrawCircle(int diameter, int width)
        {
            g.DrawEllipse(p,  Xpos, Ypos, diameter, width);
            //If conditon to know whether to fill shape or not
            if (fil)

            {
                g.FillEllipse(brush, Xpos, Ypos, diameter, width);
            }
        }

       /// <summary>
       /// to display soome error on color black having width of 8
       /// </summary>
       /// <param name="error"></param>
        public void displayerror(string error)
        {
            g.DrawString(error, new Font("Tahoma", 8), Brushes.Black, Xpos, Ypos);
        }



    }
}


    
