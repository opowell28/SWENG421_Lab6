using System;
using Xamarin.Forms;

namespace SWENG421_Lab6
{
	public class Edge : ContentPage
	{
		public int edge_id;
		public Vertex from_vertex;
		public Vertex to_vertex;

		public Edge()
		{
			edge_id = 0;
			from_vertex = null;
			to_vertex = null;
		}

		public Edge(int id, Vertex from, Vertex to)
		{
			edge_id = id;
			from_vertex = from;
			to_vertex = to;
		}

		public void draw()
		{
            // create a new canvas
            var canvas = new SkiaSharp.Views.Forms.SKCanvasView();

            // sets the paint color to black
            var paint = new SkiaSharp.SKPaint
            {
                Color = SkiaSharp.SKColors.Black
            };

			// paint a line between the specified vertices
			canvas.PaintSurface += (sender, e) =>
			{
				var canvas2D = e.Surface.Canvas;
				canvas2D.DrawLine(from_vertex, to_vertex, paint);
			};

			Content = canvas;
        }
	}
}

