using Godot;
using System;
using System.Collections.Generic;

class CastOnHit : IAugment, ICastsSkill
{
    public static bool CanApply(IAugment aug)
    {
        return aug is SkillBase;
    }

    public void Apply(IAugment skill)
    {
        GD.Print("CastOnHit Applied");
    }

    public class Static : AugmentStatic
    {
        public Static() : base("cast_on_hit", "casts_skill") { }
        public override IAugment New() => new CastOnHit();
    }
}