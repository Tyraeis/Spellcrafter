using Godot;
using System;

public class Tmp : Node
{
    public override void _Ready()
    {
        IAugmentTree<TestSkill> a = new AugmentTree<TestSkill>();

        IAugmentTree<AddedDamage> b = new AugmentTree<AddedDamage>();
        a.AddChild(b);

        IAugmentTree<CastOnHit> c = new AugmentTree<CastOnHit>();
        a.AddChild(c);

        IAugmentTree<TestSkill> d = new AugmentTree<TestSkill>();
        c.AddChild(d);

        TestSkill t = a.Build();
        t.Cast();
    }
}
