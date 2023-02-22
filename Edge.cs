using Xamarin.Forms;

namespace SWENG421_Lab6
{
    public class Edge : ContentView
    {
        public int EdgeId;
        public Vertex FromVertex;
        public Vertex ToVertex;

        public Edge()
        {
            EdgeId = 0;
            FromVertex = null;
            ToVertex = null;
        }

        public Edge(int id, Vertex from, Vertex to)
        {
            EdgeId = id;
            FromVertex = from;
            ToVertex = to;
        }

        public void Draw()
        {
            // Create a BoxView to represent the edge
            var box = new BoxView
            {
                Color = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            // Calculate the position and size of the BoxView
            double edgeLength = DistanceBetweenVertices(FromVertex, ToVertex);
            double edgeAngle = AngleBetweenVertices(FromVertex, ToVertex);
            double edgeX = FromVertex.x_coordinate;
            double edgeY = FromVertex.y_coordinate - edgeLength / 2;
            double edgeWidth = 5;

            // Set the position and size of the BoxView
            AbsoluteLayout.SetLayoutBounds(box, new Rectangle(edgeX, edgeY, edgeWidth, edgeLength));
            AbsoluteLayout.SetLayoutFlags(box, AbsoluteLayoutFlags.None);

            // Rotate the BoxView to match the angle between the vertices
            box.Rotation = edgeAngle;

            // Set the content of the ContentView to the BoxView
            Content = box;
        }

        // Helper function to calculate the distance between two vertices
        private double DistanceBetweenVertices(Vertex v1, Vertex v2)
        {
            double xDiff = v2.x_coordinate - v1.x_coordinate;
            double yDiff = v2.y_coordinate - v1.y_coordinate;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        // Helper function to calculate the angle between two vertices
        private double AngleBetweenVertices(Vertex v1, Vertex v2)
        {
            double xDiff = v2.x_coordinate - v1.x_coordinate;
            double yDiff = v2.y_coordinate - v1.y_coordinate;
            return Math.Atan2(yDiff, xDiff) * 180 / Math.PI;
        }
    }
}
