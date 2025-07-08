public class CityWithoutEnumirator
{
    public string Name { get; }
    public List<Sight> Sights { get; }

    public CityWithoutEnumirator(string name, List<Sight> sights)
    {
        Name = name;
        Sights = sights;
    }

    public GuideWithoutEnumantor GetEnumerator()
    {
        return new GuideWithoutEnumantor(Sights);
    }
}