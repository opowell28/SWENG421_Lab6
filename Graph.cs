using System;
using Xamarin.Forms;

namespace SWENG421_Lab6
{
	public class Graph : ContentPage
	{
		public string graph_id;
        List<Vertex> vertices = new List<Vertex>();
        List<Edge> edges = new List<Edge>();

		public Graph()
		{
			graph_id = "default";
		}

		public Graph(string id)
		{
			graph_id = id;
		}

		// adds a vertex to the list of vertices
		public void addVertex(Vertex v)
		{
			vertices.Add(v);
		}

		// adds an edge to the list of edges
		public void addEdge(Edge e)
		{
			edges.Add(e);
		}

		// print each vertex and edge
		public void print()
		{
			for (int i = 0; i < vertices.Capacity; i++)
			{
				for (int j = 0; j < edges.Capacity; j++)
				{
					vertices[i].Draw(vertices[i].x_coordinate, vertices[i].y_coordinate);
					edges[j].draw(edges[j].from_vertex, edges[j].to_vertex);
				}
			}
		}
	}
}

