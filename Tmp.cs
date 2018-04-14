using Godot;
using System;
using System.Collections.Generic;

public class Tmp : Node
{
    public override void _Ready()
    {
        new AddedDamage.Static().Register();
        new CastOnHit.Static().Register();
        new TestSkill.Static().Register();

        AugmentTree a = new AugmentTree("test_skill");

        AugmentTree b = new AugmentTree("added_damage");
        a.AddChild(b);

        AugmentTree c = new AugmentTree("cast_on_hit");
        a.AddChild(c);

        AugmentTree d = new AugmentTree("test_skill");
        c.AddChild(d);

        TestSkill t = (TestSkill)a.Build();
        t.Cast();
    }
}
