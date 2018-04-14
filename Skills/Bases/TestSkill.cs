using System;
using Godot;

class TestSkill : SkillBase, IDealsDamage
{
    public override void Cast()
    {
        GD.Print("TestSkill Cast");
    }

    public class Static : AugmentStatic
    {
        public Static() : base("test_skill", "deals_damage") { }
        public override IAugment New() => new TestSkill();
    }
}