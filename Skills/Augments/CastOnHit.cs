using System;

class CastOnHit : IAugment<SkillBase>, ICastsSkill
{
    public void Apply(SkillBase skill)
    {
        throw new NotImplementedException();
    }

    static CastOnHit()
    {
        AugmentRegistry.Register(() => new CastOnHit());
    }
}