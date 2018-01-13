using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_17_Graphs
{
    public class Graph<T> where T : IComparable
    {
        //list of GraphNodes in this graph
        private LinkedList<GraphNode<T>> nodes;

        //constructor - set nodes to new empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        //only return true if the graph’s list of nodes is empty
        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }

        //Search through list of nodes for node
        //Node will be a newgraphnode with the
        //containing the ID to be search for
        public bool ContainsGraph(GraphNode<T> node)
        {
            //search based on ID
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //find from in list of nodes and search its adjList for to
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    if (from.GetAdjList().Contains(to.ID))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //add a new graphNode to list of nodes
        public void AddNode(T id)
        {
            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }

        //Search through list of nodes for node with this ID
        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                {
                    return n;
                }
            }
            return null;
        }

        //find from in list of nodes(look at other methods)
        //and call graphNode method to add an edge to 'to'
        //think about validation here
        public void AddEdge(T from, T to)
        {
            GraphNode<T> fromNode = new GraphNode<T>(from);
            GraphNode<T> toNode = new GraphNode<T>(to);
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(fromNode.ID) == 0 && !IsAdjacent(fromNode, toNode))
                {
                    n.AddEdge(toNode);                
                }
            }
        }
            

        //perform a DFS traversal starting at startID, leaving a list
        //of visited ID’s in the visited list.
        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();
            GraphNode<T> current;
            toVisit.Push(startID);

            while (toVisit.Count != 0)
            {
                current = GetNodeByID(toVisit.Peek());
                toVisit.Pop();
                visited.Add(current.ID);
                adj = current.GetAdjList();
                foreach (T id in adj)
                {
                    if (!toVisit.Contains(id) && !visited.Contains(id))
                    {
                        toVisit.Push(id);
                    }
                }
                //get current node and add unique adjacent nodes to
                //toVisit
            }
        }

        //perform a BFS traversal starting at startID, leaving a list 
        //of visited ID’s in the visited list.  
        public void BreadthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current;
            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                current = GetNodeByID(toVisit.Peek());
                toVisit.Dequeue();
                visited.Add(current.ID);
                adj = current.GetAdjList();
                foreach (T id in adj)
                {
                    if (!toVisit.Contains(id) && !visited.Contains(id))
                    {
                        toVisit.Enqueue(id);
                    }
                }
                //get current node and add unique adjacent nodes to
                //toVisit
            }
        }
    }
}