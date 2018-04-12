using System;

class AddedDamage : IAugment<IDealsDamage>
{
    public void Apply(IDealsDamage obj)
    {
        throw new NotImplementedException();
    }

    static AddedDamage()
    {
        AugmentRegistry.Register(() => new AddedDamage());
    }
}