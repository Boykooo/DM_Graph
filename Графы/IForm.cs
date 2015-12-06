using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графы
{
    interface IForm
    {
        void ReDraw(Bitmap bt);
        void StatusSearch(int p);
    }
}
