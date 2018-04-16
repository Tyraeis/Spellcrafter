using Godot;
using Spellcrafter.Crafting;

namespace Spellcrafter.Skills
{
    class AddedDamage : IAugment
    {
        public void Apply(IAugment obj)
        {
            GD.Print("AddedDamage Applied");
        }

        public class Static : AugmentStatic
        {
            public Static() : base("added_damage") { }
            public override IAugment New() => new AddedDamage();
            public override bool CanApplyTo(AugmentStatic aug)
            {
                return true;
            }
        }
    }
}