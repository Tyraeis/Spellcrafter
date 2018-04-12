using System;

abstract class SkillBase : IAugment<ICastsSkill>
{
    public abstract void Cast();

    public void Apply(ICastsSkill obj)
    {
        throw new NotImplementedException();
    }
}