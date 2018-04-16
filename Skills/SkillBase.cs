using Spellcrafter.Crafting;

namespace Spellcrafter.Skills
{
    abstract class SkillBase : IAugment
    {
        public abstract void Cast();

        public void Apply(IAugment obj)
        {
            if (obj is ICastsSkill cs)
            {
                cs.SetSkill(this);
            }
        }

        public abstract class SkillStatic : AugmentStatic
        {
            public SkillStatic(string id, params string[] props) : base(id, props)
            {
                this.props.Add("skill");
            }

            public override bool CanApplyTo(AugmentStatic aug)
            {
                return aug.Is("casts_skill");
            }
        }
    }
}