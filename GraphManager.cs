using Xamarin.Forms;

namespace SWENG421_Lab6;
public class GraphManager : ContentPage
{
    private GraphManager GmInstance { get; set; }

    public GraphManager()
    {
        GmInstance = new GraphManager();
    }

    /* list of vertices and edges will be passed to this method and a new graph is created
    and those vertices and edges are added to its list */
    public Graph CreateGraph(List<Vertex> vertices, List<Edge> edges)
    {
        Graph g = new Graph();
        foreach (var v in vertices)
        {
            g.AddVertex(v);
        }

        foreach (var e in edges)
        {
            g.AddEdge(e);
        }

        return g;
    }
    
    public Graph CopyGraph(Graph originalGraph)
    {
        Graph newGraph = new Graph();

        // Copy the vertices
        foreach (Vertex vertex in originalGraph.vertices)
        {
            Vertex newVertex = new Vertex(vertex.X, vertex.Y); // Create a new vertex with the same coordinates
            newGraph.AddVertex(newVertex);
        }

        // Copy the edges
        foreach (Edge edge in originalGraph.edges)
        {
            int startIndex = originalGraph.vertices.IndexOf(edge.Start);
            int endIndex = originalGraph.vertices.IndexOf(edge.End);
            Edge newEdge = new Edge(newGraph.vertices[startIndex], newGraph.vertices[endIndex]); // Create a new edge with the same start and end vertices
            newGraph.AddEdge(newEdge);
        }

        return newGraph;
    }
    
    public void EditGraph(Graph graph, Vertex vertexToEdit, double newX, double newY)
    {
        // Find the vertex to edit in the graph's vertices list
        int index = graph.vertices.IndexOf(vertexToEdit);

        if (index >= 0)
        {
            // Update the vertex's position
            Vertex editedVertex = graph.vertices[index];
            editedVertex.X = newX;
            editedVertex.Y = newY;

            // Update the position of all edges that connect to the edited vertex
            foreach (Edge edge in graph.edges)
            {
                // Update the start or end vertex of the edge as necessary
                if (edge.Start == vertexToEdit)
                {
                    edge.Start = editedVertex;
                }
                else if (edge.End == vertexToEdit)
                {
                    edge.End = editedVertex;
                }
            }
        }
    }

}