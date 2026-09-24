using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Skeleton : Entity.Character
{
    public Skeleton(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 20;
        Strength = 6;
        Intelligence = 1;
        Agility = 4;
        Crit_chance = 10;
        Crit_dmg = 40;
    }
    public int Attack()
    {
        return Strength * 3;
    }
    public string SpecialAbility()
    {
        return "Skeleton summons a single sword to fight with";
    }
}