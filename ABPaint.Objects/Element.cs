﻿// ***********************************************************************
// Assembly         : ABPaint
// Author           : Alex
// Created          : 11-25-2017
//
// Last Modified By : Alex
// Last Modified On : 03-24-2018
// ***********************************************************************
// <copyright file="Element.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ABPaint.Objects
{
    /// <summary>
    /// The objects that are found within this application on the canvas. An element is one of these objects.
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// The location of this element.
        /// </summary>
        public int X, Y;

        /// <summary>
        /// The size of this element.
        /// </summary>
        public int Width, Height;

        /// <summary>
        /// The Zindex, compared to all the other elements, of this element.
        /// </summary>
        public int Zindex;

        /// <summary>
        /// Gets or sets whether you can see this element.
        /// </summary>
        public bool Visible = true;

        /// <summary>
        /// Gets the top of this element.
        /// </summary>
        public int Top { get { return Y; } }

        /// <summary>
        /// Gets the bottom of this element.
        /// </summary>
        public int Bottom { get { return Y + Height; } }

        /// <summary>
        /// Gets the left of this element.
        /// </summary>
        public int Left { get { return X; } }

        /// <summary>
        /// Gets the right of this element.
        /// </summary>
        public int Right { get { return X + Width; } }

        /// <summary>
        /// When drawing this element, draw at the X and Y.
        /// </summary>
        public bool DrawAtLocation = true;

        /// <summary>
        /// The X location to draw the graphics to - based on <see cref="DrawAtLocation"/>. NOTE: Protected property.
        /// </summary>
        protected int DrawAtX { get { return (DrawAtLocation) ? X : 0; } }

        /// <summary>
        /// The Y location to draw the graphics to - based on <see cref="DrawAtLocation"/>. NOTE: Protected property.
        /// </summary>
        protected int DrawAtY { get { return (DrawAtLocation) ? Y : 0; } }

        /// <summary>
        /// What gets ran when the element is drawn.
        /// The graphics are drawn to a graphics object at the X and Y of the element.
        /// If you don't want that to happen at those co-ordinates - change the <see cref="DrawAtLocation"/> property to false.
        /// </summary>
        public abstract void ProcessImage(Graphics g);

        /// <summary>
        /// Changes certain values within the element to adjust to a new size.
        /// </summary>
        public abstract void Resize();

        /// <summary>
        /// Changes certain values within the element after it has resized.
        /// </summary>
        public abstract void FinishResize();
    }
}
