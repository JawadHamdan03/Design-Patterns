using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Singleton;

public class Singleton
{
    private static Singleton instance;

    private Singleton()
    {

    }
    public static Singleton CreateInstance()
    {
        if (instance == null)
        {
            instance= new Singleton();
        }
        return instance;
    }
}
