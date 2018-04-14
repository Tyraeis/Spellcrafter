using System;
using Godot;

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
    }
}