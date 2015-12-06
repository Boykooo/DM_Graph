using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графы
{
    public partial class Form1 : Form, IForm
    {
        private ActForm act;
        public Form1()
        {
            InitializeComponent();
            act = new ActForm(pictureBox1.Width, pictureBox1.Height, this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    act.AddNode(e.Location);
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    act.AddEdge(e.Location);
                    break;
            }

        }
        public void ReDraw(Bitmap bt)
        {
            pictureBox1.Image = bt;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            act.Clear();
            Status.Text = "";
        }
        private void StepButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Depth.Checked)
                {
                    act.Depth();
                }
                else if (Breadth.Checked)
                {
                    act.Breadth();
                }
                else if (Prim.Checked)
                {
                    act.Prim();
                }
                else if (Kruskal.Checked)
                {
                    act.Kruskal();
                }
            }
            catch { Status.Text = "Конец"; }
        }
        public void StatusSearch(int p)
        {
            Status.Text += p.ToString() + ";";
        }
    }
}
