using Godot;
using Spellcrafter.Crafting;

namespace Spellcrafter.Skills
{
    class CastOnHit : IAugment, ICastsSkill
    {
        SkillBase skill;

        public void Apply(IAugment skill)
        {
            GD.Print("CastOnHit Applied");
        }

        public void SetSkill(SkillBase skill)
        {
            this.skill = skill;
        }

        public class Static : AugmentStatic
        {
            public Static() : base("cast_on_hit", "casts_skill") { }
            public override IAugment New() => new CastOnHit();
            public override bool CanApplyTo(AugmentStatic aug)
            {
                return true;
            }
        }
    }
}