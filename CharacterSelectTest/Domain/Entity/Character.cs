using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Crit_chance { get; protected set; }
    public int Crit_dmg { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility}");
    }
}