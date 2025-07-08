using System;
using System.Collections;
using System.Collections.Generic;

public class GuideWithEnumerator : IEnumerator<Sight>
{
    public int CurrentIndex { get; set; }
    public List<Sight> Sights { get; }

    public GuideWithEnumerator(List<Sight> sights)
    {
        CurrentIndex = -1;
        Sights = sights;
    }

    public Sight Current
    {
        get { return Sights[CurrentIndex]; }
    }
    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        CurrentIndex++;
        return CurrentIndex < Sights.Count;
    }

    public void Reset()
    {
        CurrentIndex = -1;
    }

    public void Dispose() { }
}
