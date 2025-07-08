public class GuideWithoutEnumantor
{
    public int CurrentIndex { get; set; }
    public List<Sight> Sights { get; }
    public Sight Current
    {
        get
        {
            return Sights[CurrentIndex];
        }
    }

    public GuideWithoutEnumantor(List<Sight> sights)
    {
        CurrentIndex = -1;
        Sights = sights;
    }

    public bool MoveNext()
    {
        CurrentIndex++;
        if (CurrentIndex >= Sights.Count)
        {
            return false;
        }
        return true;
    }
}