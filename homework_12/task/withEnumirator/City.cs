using System;
using System.Collections;
using System.Collections.Generic;

public class CityWithEnumerator : IEnumerable<Sight>
{
    public string Name { get; }
    public List<Sight> Sights { get; }

    public CityWithEnumerator(string name, List<Sight> sights)
    {
        Name = name;
        Sights = sights;
    }

    public IEnumerator<Sight> GetEnumerator()
    {
        return new GuideWithEnumerator(Sights);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
