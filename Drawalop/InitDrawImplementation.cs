using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Drawalop;


//this is the concrete implementorcxz

public class InitDrawImplementation : InitDraw
{
    public void DrawVectorBasedCircle(Graphics graphics, Pen pen, RectangleF shape)
    {
        graphics.DrawEllipse(pen, shape);
    }

    public void DrawVectorBasedRectangle(Graphics graphics, Pen pen, RectangleF shape)
    {
        graphics.DrawRectangle(pen, shape);
    }

    public void DrawRasterBasedRectangle(Graphics graphics, Pen pen, RectangleF shape)
    {
        graphics.DrawRectangle(pen, shape);
    }

    public void DrawRasterBasedCircle(Graphics graphics, Pen pen, RectangleF shape)
    {
        graphics.DrawEllipse(pen, shape);
    }
}
