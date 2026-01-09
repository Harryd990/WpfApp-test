using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp_test
{
    // cords start at 0,0 IN TOP LEFT CORNER
    class Gridbuilder
    {
        public static void DrawALine(Canvas c, int Startx, int StartY, int EndX, int EndY)
        {
            //clear the canvas
            //c.Children.Clear(); // children is everything inside the canvas


            //create a line
            Line myLine = new Line();
            myLine.Stroke = Brushes.Black; // type of tool and color 
            myLine.StrokeThickness = 2; // set thickness

            //set start point
            myLine.X1 = Startx; // x coordinate
            myLine.Y1 = StartY; // y coordinate

            //set end point
            myLine.X2 = EndX; // x coordinate
            myLine.Y2 = EndY; // y coordinate
            //add line to canvas
            c.Children.Add(myLine);
        }
        public static void DrawABox(Canvas c, int Startx, int StartY, int Width, int Height)
        {
            //top edge
            DrawALine(c, Startx, StartY, Startx + Width, StartY);
            // left edge 
            DrawALine(c, Startx, StartY, Startx, StartY + Height);
            // right edge
            DrawALine(c, Startx + Width, StartY, Startx + Width, StartY + Height);
            // bottom edge
            DrawALine(c, Startx, StartY + Height, Startx + Width, StartY + Height);



        }
        public static void DrawAGrid(Canvas c, int Startx, int StartY, int CellWidth, int CellHeight, int NumCols, int NumRows)
        {
            // draw boxes using drawabox 
            for (int row = 0; row <= NumRows; row++)
            {

                for (int col = 0; col <= NumCols; col++)
                {
                    int x = Startx + col * CellWidth;
                    int y = StartY + row * CellHeight;
                    DrawABox(c, x, y, CellWidth, CellHeight);
                }
            }


        }
    }
}
