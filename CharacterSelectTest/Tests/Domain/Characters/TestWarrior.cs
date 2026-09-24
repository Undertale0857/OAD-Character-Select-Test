using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class WarriorTests
    {
        [TestMethod]
        public void HasCorrectName()
        {
            var warrior = new Warrior("Gerald");

            Assert.AreEqual("Gerald", warrior.Name);
        }

        [TestMethod]
        public void HasCorrectBaseStats()
        {
            var warrior = new Warrior("Gerald");

            Assert.AreEqual(150, warrior.Health);
            Assert.AreEqual(20, warrior.Strength);
            Assert.AreEqual(3, warrior.Intelligence);
            Assert.AreEqual(10, warrior.Agility);
            Assert.AreEqual(50, warrior.Crit_chance);
            Assert.AreEqual(100, warrior.Crit_dmg);
        }

        [TestMethod]
        public void DamageReturnsCorrectValue()
        {
            var warrior = new Warrior("Gerald");

            double actualAttack = warrior.Attack();

            Assert.AreEqual(60, actualAttack);
        }

        [TestMethod]
        public void SpecialAbilityReturnsCorrectMessage()
        {
            var warrior = new Warrior("Gerald");
            Assert.AreEqual("Warrior enrages losing 15% of max hp and gains 50% more attack dmg for 25 sec", warrior.SpecialAbility());
        }
    }
}