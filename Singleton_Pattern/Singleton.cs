using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern;

public sealed class Singleton
{
    private static Singleton? _Instance { get; set; }

    private static readonly object _lock = new();

    private Singleton()
    {
        
    }

    public static Singleton CreateInstance()
    {
        lock (_lock) // this lock will work, but will be used on every refernce to Singleton
        {
            if (_Instance is null)
                _Instance = new Singleton();
            return _Instance;
        }
    }
}
