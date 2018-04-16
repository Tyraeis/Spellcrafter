using System;
using System.Collections.Generic;

namespace Spellcrafter.Crafting
{
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

        public bool Is(params string[] required)
        {
            foreach (string i in required)
            {
                if (!props.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }

        public abstract IAugment New();
        public abstract bool CanApplyTo(AugmentStatic aug);
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

        public static bool CanApply(string id, string to)
        {
            return Get(id).CanApplyTo(Get(to));
        }
    }
}