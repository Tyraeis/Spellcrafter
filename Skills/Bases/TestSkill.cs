using Godot;
using Spellcrafter.Crafting;

namespace Spellcrafter.Skills
{
    class TestSkill : SkillBase, IDealsDamage
    {
        public override void Cast()
        {
            GD.Print("TestSkill Cast");
        }

        public class Static : SkillStatic
        {
            public Static() : base("test_skill", "deals_damage") { }
            public override IAugment New() => new TestSkill();
        }
    }
}