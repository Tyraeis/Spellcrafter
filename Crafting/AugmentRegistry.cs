using System;
using System.Collections.Generic;

class AugmentRegistry
{
    static Dictionary<Type, Func<object>> registry = new Dictionary<Type, Func<object>>();

    public static void Register<T>(Func<T> builder) where T: class
    {
        registry[typeof(T)] = builder;
    }

    public static Func<T> Get<T>() where T: class
    {
        return (Func<T>)registry[typeof(T)];
    }

    public static T Build<T>() where T: class
    {
        return Get<T>()();
    }
}