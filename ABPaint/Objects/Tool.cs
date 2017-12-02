﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPaint.Objects
{
    /// <summary>
    /// The tools within the toolbox - commonly used for knowing what tool is selected.
    /// </summary>
    public enum Tool
    {
        Selection = 0,
        BitmapSelection = 1,
        Pencil = 2,
        Brush = 3,
        Rectangle = 4,
        Ellipse = 5,
        Line = 6,
        Fill = 7,
        Text = 8
    }
}
