using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawalop
{
    public interface IAbstracDraw
    {
        void DrawVectorCircle(int x, int y, int h, int w, Pen pen);
        void DrawVectorRectangle(int x, int y, int h, int w, Pen pen);

        void DrawRasterCircle(int x, int y, int h, int w, Pen pen);
        void DrawRasterRectangle(int x, int y, int h, int w, Pen pen);


    }

}
