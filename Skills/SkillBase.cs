using System;
using Godot;

abstract class SkillBase : IAugment
{
    public abstract void Cast();

    public void Apply(IAugment obj)
    {
        GD.Print("SkillBase Applied");
    }
}