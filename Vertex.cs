using Xamarin.Forms;

namespace SWENG421_Lab6
{
    public class Vertex : ContentView
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

        // Draws the vertex on the canvas
        public void Draw()
        {
            // Create a BoxView to represent the vertex
            var box = new BoxView
            {
                Color = Color.Black,
                WidthRequest = 10,
                HeightRequest = 10,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,
            };

            // Set the position of the BoxView
            AbsoluteLayout.SetLayoutBounds(box, new Rectangle(x_coordinate, y_coordinate, 10, 10));

            // Set the content of the ContentView to the BoxView
            Content = box;
        }
    }
}