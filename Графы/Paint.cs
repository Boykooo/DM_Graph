using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графы
{
    class Paint
    {
        public int Radius { get; set; }
        private Bitmap mainBT;
        private Pen ellipse;
        private Font font;
        public Paint(int wh, int ht)
        {
            mainBT = new Bitmap(wh, ht);
            Radius = 20;
            ellipse = new Pen(Color.Blue, 3.0f);
            font = new Font("Times New Roman", 15f);
        }
        public Bitmap DrawGraph(List<Node> nodes)
        {
            using(Graphics g = Graphics.FromImage(mainBT))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.White);
                for (int i = 0; i < nodes.Count; i++)
                {
                    for (int j = 0; j < nodes[i].edges.Count; j++)
                    {
                        g.DrawLine(new Pen(nodes[i].edges[j].Color, 2f), new Point(nodes[i].Location.X + 10, nodes[i].Location.Y + 10), new Point(nodes[i].edges[j].End.Location.X + 10, nodes[i].edges[j].End.Location.Y + 10));
                        g.DrawString(nodes[i].edges[j].Weight.ToString(), font, Brushes.Red, new PointF(((nodes[i].Location.X + nodes[i].edges[j].End.Location.X) / 2 - 8), ((nodes[i].Location.Y + nodes[i].edges[j].End.Location.Y)) / 2 - 8));
                    }
                }
                for (int i = 0; i < nodes.Count; i++)
                {
                    g.DrawEllipse(ellipse, nodes[i].Location.X, nodes[i].Location.Y, Radius*2, Radius*2);
                    g.FillEllipse(new SolidBrush(nodes[i].Color), nodes[i].Location.X, nodes[i].Location.Y, Radius * 2, Radius * 2);
                    g.DrawString(nodes[i].Key.ToString(), font, Brushes.Black, nodes[i].Location.X + 10, nodes[i].Location.Y + 10);
                }
            }
            return mainBT;
        }
    }
}
