using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Application.Factory;

public static class CharacterFactory
{
    public static Domain.Entity.Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Warrior => new Warrior(name ?? "Warrior"),
            CharacterClass.Mage    => new Mage(name ?? "Mage"),
            CharacterClass.Rogue   => new Rogue(name ?? "Rogue"),
            CharacterClass.Necromancer   => new Necromancer(name ?? "Necromancer"),
            CharacterClass.Healer   => new Healer(name ?? "Healer"),
            CharacterClass.Skeleton => new Skeleton(name ?? "Skeleton"),
            _ => throw new ArgumentOutOfRangeException(nameof(cls), "Nieznana klasa postaci.")
        };
    }
}