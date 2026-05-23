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
        if (_Instance is null)
        {
            lock (_lock) // ony get a lock if _Instance is null 
            {
                if (_Instance is null)
                    _Instance = new Singleton();
                
            }
        }
        return _Instance;
    }
}
