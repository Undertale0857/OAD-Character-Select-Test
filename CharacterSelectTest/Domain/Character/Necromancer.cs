using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Necromancer : Entity.Character
{
    public Necromancer(string name) : base(name, CharacterClass.Necromancer)
    {
        Health = 30;
        Strength = 3;
        Intelligence = 26;
        Agility = 4;
        Crit_chance = 15;
        Crit_dmg = 30;
    }

    public int Attack()
    {
        return Strength * 3;
    }
    public string SpecialAbility()
    {
        return "Necromancer rises the dead army back to life , 3 skeletons appear infront of him";
    }
}