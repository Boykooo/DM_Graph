using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графы
{
    class ActForm
    {
        private IForm form;
        private MyGraph graph, depthGraph, breadthGraph, PrimGraph, KruskalGraph;
        private Paint draw;
        private Point? tempOne, tempTwo;
        private List<Edge> primEdges;
        private Stack<Node> stack;
        private Queue<Node> queue;
        private Node lastNode;
        public ActForm(int wh, int ht, IForm form)
        {
            graph = new MyGraph();
            depthGraph = null;
            breadthGraph = null;
            draw = new Paint(wh, ht);
            tempOne = null;
            tempTwo = null;
            this.form = form;
            stack = new Stack<Node>();
        }
        public void Clear()
        {
            graph = new MyGraph();
            depthGraph = null;
            breadthGraph = null;
            KruskalGraph = null;
            PrimGraph = null;
            tempOne = null;
            tempTwo = null;
        }
        public void AddNode(Point location)
        {
            graph.AddNode(location);
            tempOne = null;
            tempTwo = null;
            form.ReDraw(draw.DrawGraph(graph.Nodes));
        }
        public void AddEdge(Point loc)
        {
            int x = FindIndex(loc);
            if (x != -1)
            {
                if (tempOne == null)
                {
                    tempOne = graph.Nodes[x].Location;
                }
                else if (tempTwo == null)
                {
                    tempTwo = graph.Nodes[x].Location;
                    if (tempOne != tempTwo)
                    {
                        graph.AddEdge(tempOne, tempTwo);
                        tempOne = null;
                        tempTwo = null;
                        form.ReDraw(draw.DrawGraph(graph.Nodes));
                    }
                    else
                    {
                        tempOne = null;
                        tempTwo = null;
                    }
                }
            }
            else if (tempOne != null)
            {
                tempOne = null;
            }
        }
        public int FindIndex(Point location)
        {
            return graph.Nodes.FindIndex
                (x =>
                    Math.Sqrt
                    (
                      (x.Location.X - location.X) * (x.Location.X - location.X)
                    + (x.Location.Y - location.Y) * (x.Location.Y - location.Y)
                    ) < draw.Radius*2
                );
        }
        public void Depth()
        {
            if (depthGraph == null)
            {
                depthGraph = new MyGraph();
                depthGraph.InitNodes(graph.Nodes);
                depthGraph.Nodes[0].Color = Color.Red;
                depthGraph.Nodes[0].Visit = true;
                stack.Push(depthGraph.Nodes[0]);
            }
            else if (stack.Count != 0)
            {
                DepthStep();
            }
            else
            {
                throw new Exception();
            }
            form.ReDraw(draw.DrawGraph(depthGraph.Nodes));
        }
        private void DepthStep()
        {
            Node p = stack.Pop();
            int x = UnvisitedNode(p.edges);
            if (x != -1)
            {
                stack.Push(p);
                p.edges[x].End.Color = Color.Red;
                p.edges[x].End.Visit = true;
                stack.Push(p.edges[x].End);
            }
        }
        private int UnvisitedNode(List<Edge> nodes)
        {
            return nodes.FindIndex((x) => x.End.Visit == false); 
        }
        public void Breadth()
        {
            if (breadthGraph == null)
            {
                queue = new Queue<Node>();
                breadthGraph = new MyGraph();
                breadthGraph.InitNodes(graph.Nodes);
                breadthGraph.Nodes[0].Color = Color.Red;
                breadthGraph.Nodes[0].Visit = true;
                lastNode = breadthGraph.Nodes[0];
            }
            else 
            {
                BreadthStep();
            }
            form.ReDraw(draw.DrawGraph(breadthGraph.Nodes));
        }
        public void BreadthStep()
        {
            int index = UnvisitedNode(lastNode.edges);
            if (index != -1)
            {
                lastNode.edges[index].End.Color = Color.Red;
                lastNode.edges[index].End.Visit = true;
                queue.Enqueue(lastNode.edges[index].End);
            }
            else
            {
                if (queue.Count != 0)
                {
                    lastNode = queue.Dequeue();
                    lastNode.Color = Color.Red;
                    lastNode.Visit = true;
                }
            }
        }
        public void Prim()
        {
            if (PrimGraph == null)
            {
                primEdges = new List<Edge>();
                PrimGraph = new MyGraph();
                PrimGraph.InitNodes(graph.Nodes);
                PrimGraph.Nodes[0].Color = Color.Red;
                PrimGraph.Nodes[0].Visit = true;
                AddRange(PrimGraph.Nodes[0]);
            }
            else 
            {
                PrimStep();
            }
            form.ReDraw(draw.DrawGraph(PrimGraph.Nodes));
        }
        private void PrimStep()
        {
            if (primEdges.Count != 0)
            {
                int min = primEdges.Min(x => x.Weight);
                int index = primEdges.FindIndex((x) => x.Weight == min);
                form.StatusSearch(primEdges[index].End.Key);
                primEdges[index].End.Visit = true;
                primEdges[index].End.Color = Color.Red;
                //primEdges[index].Color = Color.Red;
                AddRange(primEdges[index].End);
                primEdges.RemoveAll((x) => x.End.Key == primEdges[index].End.Key);
            }
        }
        private void AddRange(Node node)
        {
            for (int i = 0; i < node.edges.Count; i++)
            {
                if (node.edges[i].End.Visit == false)
                {
                    primEdges.Add(node.edges[i]);
                }
            }
        }
    }
}
