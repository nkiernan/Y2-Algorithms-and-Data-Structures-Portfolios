using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_17_Graphs
{
    public class GraphNode<T>
    {
        private T id; //data stored in graph 
        private LinkedList<T> adjList; //adjacency list
        
        //constructor
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        //add an edge from this node : add 'to' to the adjacency list
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddFirst(to.ID);
        }

        //set and get for ID – data stored in graph
        public T ID
        {
            set { id = value; }
            get { return id; }
        }

        //returns adjacency list – useful for traversal methods
        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }
    }
}