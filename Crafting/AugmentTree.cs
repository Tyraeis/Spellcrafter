using System;
using System.Collections.Generic;

class AugmentTree
{
    string id;
    List<AugmentTree> children = new List<AugmentTree>();

    public AugmentTree(string id)
    {
        this.id = id;
    }

    // Builds the object represented by this AugmentTree.
    // This involves invoking the builder to create the base, recursively building the child augments, then applying the child augments to the base.
    public IAugment Build()
    {
        IAugment aug = AugmentRegistry.Build(id);

        foreach (AugmentTree child in children)
        {
            child.Build().Apply(aug);
        }

        return aug;
    }

    // Adds a child augment
    public void AddChild(AugmentTree child)
    {
        children.Add(child);
    }
}