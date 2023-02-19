using System;
using Xamarin.Forms;
using SkiaSharp.Views.Forms;

namespace SWENG421_Lab6
{
	public class Vertex : ContentPage
	{
		public int vertex_id;
		public double x_coordinate;
		public double y_coordinate;

		public Vertex()
		{
			vertex_id = 0;
			x_coordinate = 0;
			y_coordinate = 0;
		}

		public Vertex(int id, double x, double y)
		{
			vertex_id = id;
			x_coordinate = x;
			y_coordinate = y;
		}

		// draws a vertex on the canvas
		public void draw()
		{
			// create a new canvas
			var canvas = new SkiaSharp.Views.Forms.SKCanvasView();

			// sets the paint color to black
			var paint = new SkiaSharp.SKPaint
			{
				Color = SkiaSharp.SKColors.Black
			};

			// draw a point at (x, y)
			canvas.PaintSurface += (sender, e) =>
			{
				var canvas2D = e.Surface.Canvas;
				canvas2D.DrawPoint(x_coordinate, y_coordinate, paint);
			};

			// add the canvas to the page
			Content = canvas;
		}
	}
}

