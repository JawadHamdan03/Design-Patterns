using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern;

public sealed class Singleton
{
    private static Singleton? _Instance { get; set; }


    private Singleton()
    {
        
    }

    public static Singleton CreateInstance()
    {
        return _Instance ??= new Singleton(); // if many threads reach this line this could cause many instanciation
                                 
    }
}
