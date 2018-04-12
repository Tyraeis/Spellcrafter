using System;

class TestSkill : SkillBase, IDealsDamage
{
    public override void Cast()
    {
        // TODO
        throw new NotImplementedException();
    }
    
    static TestSkill()
    {
        AugmentRegistry.Register(() => new TestSkill());
    }
}