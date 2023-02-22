using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace SWENG421_Lab6
{
	public class GraphManager
	{
        private static GraphManager gmInstance = new GraphManager();
        public List<Graph> graphs = new List<Graph>();

        private GraphManager() { }

        // returns the current instance of GraphManager
        public GraphManager getInstance()
        {
            return gmInstance;
        }

        public SKCanvasView createGraph(string id)
		{
			
		}

        /*This probably goes in Graph
		public void editGraph(int id, int x, int y)
		{
			v[id].x_coordinate = x;
			v[id].y_coordinate = y;
			vertices.add(v[id]);
		}
		*/
    }
}

