using System;
using System.Collections.Generic;

abstract class AugmentStatic
{
    public string id;
    public HashSet<string> props = new HashSet<string>();

    public AugmentStatic(string id, params string[] props)
    {
        this.id = id;

        foreach (string i in props)
        {
            this.props.Add(i);
        }
    }

    public void Register()
    {
        AugmentRegistry.Register(this);
    }

    public abstract IAugment New();
}

class AugmentRegistry
{
    static Dictionary<string, AugmentStatic> registry = new Dictionary<string, AugmentStatic>();

    public static void Register(AugmentStatic rec)
    {
        registry[rec.id] = rec;
    }

    public static AugmentStatic Get(string id)
    {
        return registry[id];
    }

    public static IAugment Build(string id)
    {
        return Get(id).New();
    }

    public static bool CanApply(string id, IAugment aug)
    {
        // TODO
        return true; // Get(id).canApply(aug);
    }
}