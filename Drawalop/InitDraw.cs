using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawalop
{

    //this is the abstraction class 
    // or the Implementor
    public interface InitDraw
    {
        // void Draw(Graphics graphics, Pen pen, RectangleF shape);
        void DrawRasterBasedCircle(Graphics graphics, Pen pen, RectangleF shape);
        void DrawVectorBasedCircle(Graphics graphics, Pen pen, RectangleF shape);

        void DrawRasterBasedRectangle(Graphics graphics, Pen pen, RectangleF shape);
        void DrawVectorBasedRectangle(Graphics graphics, Pen pen, RectangleF shape);
    }
}
