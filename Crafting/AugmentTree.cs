using System;
using System.Collections.Generic;

// Create an interface to allow the type parameter to be variant
// TODO: explain how variance in IAugment and IAugmentTree allow augment compatability to be checked using the type system
interface IAugmentTree<out T>
{
    T Build();
    void AddChild(IAugmentTree<IAugment<T>> child);
}

class AugmentTree<T> : IAugmentTree<T> where T: class
{
    List<IAugmentTree<IAugment<T>>> children = new List<IAugmentTree<IAugment<T>>>();

    // Builds the object represented by this AugmentTree.
    // This involves invoking the builder to create the base, recursively building the child augments, then applying the child augments to the base.
    public T Build()
    {
        T aug = AugmentRegistry.Build<T>();

        foreach (AugmentTree<IAugment<T>> child in children)
        {
            child.Build().Apply(aug);
        }

        return aug;
    }

    // Adds a child augment
    public void AddChild(IAugmentTree<IAugment<T>> child)
    {
        children.Add(child);
    }
}