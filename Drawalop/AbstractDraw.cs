using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawalop
{
    //refinned abstraaction

    public class AbstractDraw : IAbstracDraw
    {
        private readonly InitDraw _draw;
        private readonly Graphics _graphics;

        public AbstractDraw(InitDraw draw, Graphics graphics) { 
            
            this._draw = draw;
            this._graphics = graphics;
        }
 
        public void DrawVectorCircle(int x, int y, int h, int w, Pen pen)
        {

            RectangleF shape = new RectangleF(x, y, h, w);
            this._draw.DrawVectorBasedCircle(this._graphics, pen, shape);


        }

        public void DrawVectorRectangle(int x, int y, int h, int w, Pen pen)
        {
            RectangleF shape = new RectangleF(x, y, h, w);
            this._draw.DrawVectorBasedRectangle(this._graphics, pen, shape);
        }
        public void DrawRasterCircle(int x, int y, int h, int w, Pen pen)
        {

            RectangleF shape = new RectangleF(x, y, h, w);
            this._draw.DrawRasterBasedCircle(this._graphics, pen, shape);


        }

        public void DrawRasterRectangle(int x, int y, int h, int w, Pen pen)
        {
            RectangleF shape = new RectangleF(x, y, h, w);
            this._draw.DrawRasterBasedRectangle(this._graphics, pen, shape);
        }

      

    }
}
