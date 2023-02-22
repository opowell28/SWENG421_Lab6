public class Edge
{
    public Vertex Start { get; set; }
    public Vertex End { get; set; }
    public double Length { get; set; }

    public Edge(Vertex start, Vertex end)
    {
        Start = start;
        End = end;
        Length = CalculateLength();
    }

    private double CalculateLength()
    {
        double dx = End.X - Start.X;
        double dy = End.Y - Start.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}