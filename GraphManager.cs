using System;

namespace SWENG421_Lab6
{
	public class GraphManager
	{
		private GraphManager gmInstance;
		public List<Graph> graphs = new List<Graph>();

		public GraphManager()
		{
			gmInstance = new GraphManager();
		}

		// returns the current instance of GraphManager
		public GraphManager getInstance()
		{
			return gmInstance;
		}

		public void createGraph(string id)
		{
			// if the user selects a cosine graph
			if (id == "cosine")
			{
				Graph cosine = new Graph("cosine");
				
				// create vertices for a graph at (0, 0)
				Vertex v1 = new Vertex(1, -Math.PI, 1);
				Vertex v2 = new Vertex(2, (-Math.PI) / 2, 0);
				Vertex v3 = new Vertex(3, 0, -1);
				Vertex v4 = new Vertex(4, (Math.PI) / 2, 0);
				Vertex v5 = new Vertex(5, Math.PI, 1);

				// add the vertices to the cosine graph
				cosine.addVertex(v1);
                cosine.addVertex(v2);
                cosine.addVertex(v3);
                cosine.addVertex(v4);
                cosine.addVertex(v5);

				// create edges between each pair of vertices
                Edge e1 = new Edge(1, v1, v2);
				Edge e2 = new Edge(2, v2, v3);
				Edge e3 = new Edge(3, v3, v4);
				Edge e4 = new Edge(4, v4, v5);

				// add the edges to the cosine graph
				cosine.addEdge(e1);
				cosine.addEdge(e2);
				cosine.addEdge(e3);
				cosine.addEdge(e4);

				// draw the edges and vertices
				v1.draw();
				v2.draw();
				v3.draw();
				v4.draw();
				v5.draw();

				e1.draw();
				e2.draw();
				e3.draw();
				e4.draw();
			}
		}

		public void editGraph(string id)
		{

		}
	}
}

