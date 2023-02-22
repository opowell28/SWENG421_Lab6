using Xamarin.Forms;

namespace SWENG421_Lab6
{
	public class Graph : ContentPage
	{
		public string GraphId;
        public List<Vertex> vertices = new List<Vertex>();
        public List<Edge> edges = new List<Edge>();

		public Graph()
		{
			GraphId = "default";
		}

		// constructor gives the graph 
		public Graph(string id)
		{
			GraphId = id;
			Vertex origin = new Vertex(0, 0);
		}

		// adds a vertex to the list of vertices
		public void AddVertex(Vertex v)
		{
			vertices.Add(v);
		}

		// adds an edge to the list of edges
		public void AddEdge(Edge e)
		{
			edges.Add(e);
		}

		// Print each vertex and edge
		public ContentPage Print()
		{
			// Create the AbsoluteLayout to position the vertices
			AbsoluteLayout layout = new AbsoluteLayout();
			foreach (Vertex vertex in vertices)
			{
				BoxView boxView = new BoxView
				{
					Color = Color.Blue,
					WidthRequest = 20,
					HeightRequest = 20
				};
				layout.Children.Add(boxView, new Rectangle(vertex.X, vertex.Y, 20, 20));
			}
			foreach (Edge edge in edges)
			{
				BoxView boxView = new BoxView
				{
					Color = Color.Red,
					WidthRequest = 5,
					HeightRequest = edge.Length
				};
				AbsoluteLayout.SetLayoutBounds(boxView, new Rectangle(edge.Start.X, edge.Start.Y, 5, edge.Length));
				AbsoluteLayout.SetLayoutFlags(boxView, AbsoluteLayoutFlags.None);
				layout.Children.Add(boxView);
			}

			Content = layout;

			return new ContentPage();
		}
	}
}

