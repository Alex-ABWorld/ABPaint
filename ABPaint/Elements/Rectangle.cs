﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPaint.Elements
{
    class RectangleE : Element
    {
        public Color fillColor;
        public Color borderColor;
        public int BorderSize;
        public bool IsFilled;

        public override Bitmap ProcessImage()
        {
            Bitmap ret = new Bitmap(Math.Abs(Width), Math.Abs(Height));
            Graphics g = Graphics.FromImage(ret);

            // Now let's draw this rectangle!

            //Point startPoint = new Point(0, 0);

            //if (Width < 0) startPoint = new Point(Width, startPoint.Y);
            //if (Height < 0) startPoint = new Point(startPoint.X, Height);

            //if (width < 0) currentDrawingElement.Width = 1;
            //if (height < 0) currentDrawingElement.Height = 1;


            if (IsFilled) g.FillRectangle(new SolidBrush(fillColor), 0, 0, Math.Abs(Width), Math.Abs(Height)); // Fill

            g.DrawRectangle(new Pen(borderColor, BorderSize), 0, 0, Math.Abs(Width), Math.Abs(Height));

            //g.FillRectangle(new SolidBrush(borderColor), 0, 0, BorderSize, Height); // Left border
            //g.FillRectangle(new SolidBrush(borderColor), 0, 0, Width, BorderSize); // Top border
            //g.FillRectangle(new SolidBrush(borderColor), Width - BorderSize, 0, BorderSize, Height); // Right border
            //g.FillRectangle(new SolidBrush(borderColor), 0, Height - BorderSize, Width, BorderSize); // Bottom border



            return ret;
        }

        public override void Resize(int newWidth, int newHeight)
        {
            // Do Nothing
        }
    }
}