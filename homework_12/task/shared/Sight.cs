public class Sight
{
    public string Name { get; }
    public string CordinateX { get; }
    public string CordinateY { get; }

    public Sight(string name, string cordinateX, string cordinateY)
    {
        Name = name;
        CordinateX = cordinateX;
        CordinateY = cordinateY;
    }
}