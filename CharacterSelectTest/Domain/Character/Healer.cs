using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Healer : Entity.Character
{
    public Healer(string name) : base(name, CharacterClass.Healer)
    {
        Health = 50;
        Strength = 2;
        Intelligence = 14;
        Agility = 9;
        Crit_chance = 5;
        Crit_dmg = 25;
    }
    public int Attack()
    {
        return Intelligence * 3;
    }
    public string SpecialAbility()
    {
        return "Healer casts area heal healing 20% of max health";
    }
}