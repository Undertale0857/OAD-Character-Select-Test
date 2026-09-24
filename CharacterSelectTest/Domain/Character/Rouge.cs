using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 65;
        Strength = 9;
        Intelligence = 5;
        Agility = 20;
        Crit_chance = 25;
        Crit_dmg = 150;
    }
    public int Attack()
    {
        return Strength * 3;
    }
    public string SpecialAbility()
    {
        return "Rouge pickpockets enemies gaining from 10% to 25% of thier gold";
    }
}