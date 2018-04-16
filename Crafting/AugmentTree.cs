using System.Collections.Generic;

namespace Spellcrafter.Crafting
{
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

        // Adds a child augment. Returns whether the child was successfully added
        public bool AddChild(AugmentTree child)
        {
            if (AugmentRegistry.CanApply(child.id, id))
            {
                children.Add(child);
                return true;
            }
            return false;
        }
    }
}