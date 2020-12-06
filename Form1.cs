using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ASE_Assessment
{
    public partial class Form1 : Form
    {     //To create object from class Canvass
        Canvass C;
        //Bitmap create a display size for appropriate system
        Bitmap OutputBitmap = new Bitmap(600, 490);

        //int[] Parameter;

        //int Parseval;

        public Form1()
        {
            InitializeComponent();
            //Initializing Canvass as drawing object to draw image on output 
            C = new Canvass(Graphics.FromImage(OutputBitmap));
            //new variable assigned to create a drawing graphics on output bitmap
            var graphics = Graphics.FromImage(OutputBitmap);
            //font for graphics output and width for valauble font
            var font = new Font("TimesNewRoman", 10, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        /// <summary>
        /// Output box to display result on the graphics panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OutputWindow_Paint(object sender, PaintEventArgs e)
        { //subjective output image fot bitmap
            OutputWindow.Image = OutputBitmap;
        }
        /// <summary>
        /// Event handler to do some action when it is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RUN_Click(object sender, EventArgs e)
        { 
            //using variable to display image on panel
            var graphics = Graphics.FromImage(OutputBitmap);
            ////font for graphics output and width for valauble font
            var font = new Font("TimesNewRoman", 20, FontStyle.Regular, GraphicsUnit.Pixel);
            //variable to read input from richtextbox
            var cmd = InputWindow.Text;
            //variable to read imout from textbox
            var Command = CommandLine.Text;
            //to check condition whether to parse from textbox or not
            if (CommandLine.Text != "run" && string.IsNullOrEmpty(cmd))
            {
                //declaring string parameter as para
                String[] para;
                //creating an array to split the input command to spliting line
                char[] trim = { '(', ')' };
                //creating line and initializing it with trim
                string line = Command.Trim(trim).ToLower();
                //splitting syntax from parameter
                string[] split = line.Split('(');
                Command = split[0];
                try {
                    //to check input if pen have specific tasks to fill
                    if (Command.Equals("fill"))
                    {
                         // passing fillshape from canvass class using its object
                        C.fillShape(split[1]);
                    }
                    
                    else if (Command.Equals("pen"))

                    {
                        ////passing pen from canvass class using its object
                        C.pen(split[1]);

                    }
                    //to split parameter which is separated by comma
                    para = split[1].Split(',');

                    //uing for loop

                    for (int i = 0; i < para.Length - 1; i++)
                    {
                        //populating string with parameters
                        String pnt1 = para[0];
                        String pnt2 = para[1];

                        //storing parse value from strings
                        int P1 = int.Parse(pnt1);
                        int P2 = int.Parse(pnt2);
                        //to check syntax where it is correct after diplaying some output
                        if (Command.Equals("moveto") && para.Length == 2)
                        {


                            C.moveto(P1, P2);
                        }
                        else if (Command.Equals("drawto") && para.Length == 2)
                        {

                            C.DrawTo(P1, P2);
                        }
                        else if (Command.Equals("drawcircle") && para.Length == 2)
                        {
                            C.DrawCircle(P1, P2);
                        }

                        else if (Command.Equals("drawrectangle") && para.Length == 2)
                        {

                            C.DrawRectangle(P1, P2);
                        }

                        /* else if (Command.Equals("drawtriangle") && para.Length == 2)
                         {
                             C.DrawTriangle(P1, P2);
                         }*/
                        else
                        {
                            //For using invalid syntax reporting

                            graphics.DrawString("Invalid Syntax", font, Brushes.Black, new Point(0, 0));

                        }


                    }

                }
                catch (Exception)
                
                {
                    //for invalid parameters checking
                    graphics.DrawString(" ", font, Brushes.Black, new Point(0, 0));
                }
            }

            ////to check syntax where it is correct after diplaying some output in input window
            else if (CommandLine.Text == "run" || string.IsNullOrEmpty(Command) || false)

            {
                //declaring array and populating it with every new line
                string[] multiLine = cmd.Split('\n');
                String[] para;
                char[] trim = { '(', ')' };
                //using for loop for taking out everyline parameter
                for (int j = 0; j < multiLine.Length; j++)
                {
                    //declaring array and populating it with single and tidy them
                    string line = multiLine[j].Trim(trim).ToLower();
                    //using split array to store the splitted line
                    string[] split = line.Split('(');
                    //populating with first part of the command
                    cmd = split[0];
                    //by using try and catch for handling exception
                    try
                    {
                        //checking whether the enter commands are entered as they were used to 
                        if (cmd.Equals("fill"))
                        {
                            //using fillshape for drawing objects
                            C.fillShape(split[1]);
                        }

                           //using pen for drawing objects
                        else if (cmd.Equals("pen"))
                        {
                            C.pen(split[1]);

                        }
                        //splitting parameters by using comma(,)

                        para = split[1].Split(',');
                        //using for loop for taking out some parameters
                        for (int i = 0; i < para.Length - 1; i++)
                        { 
                            //point pnt1 and pnt2 stores parameters as first and second
                            String pnt1 = para[0];
                            String pnt2 = para[1];

                            //by parsing some value of string
                            int P1 = int.Parse(pnt1);
                            int P2 = int.Parse(pnt2);

                            //using various input and calling moveto by using canvas object
                            if (cmd.Equals("moveto") && para.Length == 2)
                            {


                                C.moveto(P1, P2);
                            }
                            //using various input and calling drawto by using canvas object
                            else if (cmd.Equals("drawto") && para.Length == 2)
                            {

                                C.DrawTo(P1, P2);
                            }
                            //using various input and calling drawcircle by using canvas object
                            else if (cmd.Equals("drawcircle") && para.Length == 2)
                            {
                                C.DrawCircle(P1, P2);
                            }
                            ////using various input and calling drawrectangle by using canvas object
                            else if (cmd.Equals("drawrectangle") && para.Length == 2)
                            {

                                C.DrawRectangle(P1, P2);
                            }

                            /*else if (cmd.Equals("drawtriangle") && para.Length == 2)
                            {
                                C.DrawTriangle(P1, P2);
                            }*/
                            else
                            { //displaying error for invalid syntax
                                graphics.DrawString("Invalid Syntax", font, Brushes.Black, new Point(0, 0));
                            }

                        }

                    }
                    catch (Exception)
                    {

                        //displaying error if user passed some wrong parameter
                        graphics.DrawString("Wrong Parameter Passed", font, Brushes.Black, new Point(3, 2));


                    }

                }


            }
            // checking whether user have input something or not!!
            else if (string.IsNullOrEmpty(cmd) && string.IsNullOrEmpty(Command))
            {


                graphics.DrawString("Please Enter Some Value", font, Brushes.Black, new Point(0, 0));


            }



        }

        private void RESET_Click(object sender, EventArgs e)
        {
            // for reset button setup
            C.Xpos = 0;
            C.Ypos = 0;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {   //for clear button setup to clear textfield
            InputWindow.Clear();
            CommandLine.Text = string.Empty;

        }
        /// <summary>
        /// to load file in input window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Text File (.txt)|*.txt";
            loadFileDialog.Title = "Open File...";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(loadFileDialog.FileName);
                InputWindow.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
        /// <summary>
        /// To save file from input window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (.txt)| *.txt";
            saveFileDialog.Title = "Save File...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fWriter = new StreamWriter(saveFileDialog.FileName);
                fWriter.Write(InputWindow.Text);
                fWriter.Close();
            }
            InputWindow.Text += "Command Save";
        }

    } 
    }
    
    

