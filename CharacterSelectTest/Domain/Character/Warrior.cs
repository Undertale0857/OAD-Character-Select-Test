using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;
using System.Runtime.ConstrainedExecution;

namespace CharacterSelectTest.Domain.Character;

public sealed class Warrior : Entity.Character
{
    public Warrior(string name) : base(name, CharacterClass.Warrior)
    {
        Health = 150;
        Strength = 20;
        Intelligence = 3;
        Agility = 10;
        Crit_chance = 50;
        Crit_dmg = 100;
    }

    public int Attack()
    {
        return Strength * 3;
    }
    public string SpecialAbility()
    {
        return "Warrior enrages losing 15% of max hp and gains 50% more attack dmg for 25 sec";
    }
}