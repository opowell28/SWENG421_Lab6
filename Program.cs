namespace SWENG421_Lab6;

// We started using Xamarin because I (Owen) am on MacOS and can't test Windows Forms programs

public class Program
{
    static void Main(string[] args)
    {
        GraphManager gm = new GraphManager();
        List<Vertex> vertices = new List<Vertex>();
        List<Edge> edges = new List<Edge>();

        // create vertices
        Vertex v1 = new Vertex(0, 0);
        Vertex v2 = new Vertex(1, 1);
        Vertex v3 = new Vertex(2, 2);
        Vertex v4 = new Vertex(-1, -1);
        
        // add vertices to list
        vertices.Add(v1);
        vertices.Add(v2);
        vertices.Add(v3);
        vertices.Add(v4);
        
        // create edges
        Edge e1 = new Edge(v4, v1);
        Edge e2 = new Edge(v1, v2);
        Edge e3 = new Edge(v2, v3);
        
        // add edges to list
        edges.Add(e1);
        edges.Add(e2);
        edges.Add(e3);
        
        // create a graph based on these vertices and edges
        Graph g = gm.CreateGraph(vertices, edges);
        
        // TODO: this should open a window and display the graph, but I believe there is a problem with the ContentView 
        g.Print();

        // copy graph g to create new graph g2
        Graph g2 = gm.CopyGraph(g);
        g2.Print();
        
        // edit g2 graph
        gm.EditGraph(g2, v3, 5, 4);
        g2.Print();
    }
}
