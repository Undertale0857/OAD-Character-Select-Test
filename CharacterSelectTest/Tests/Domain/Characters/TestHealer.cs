using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class HealerTests
    {
        [TestMethod]
        public void HasCorrectName()
        {
            var healer = new Healer("Michael");

            Assert.AreEqual("Michael", healer.Name);
        }

        [TestMethod]
        public void HasCorrectBaseStats()
        {
            var healer = new Healer("Michael");

            Assert.AreEqual(50, healer.Health);
            Assert.AreEqual(2, healer.Strength);
            Assert.AreEqual(14, healer.Intelligence);
            Assert.AreEqual(9, healer.Agility);
            Assert.AreEqual(5, healer.Crit_chance);
            Assert.AreEqual(25, healer.Crit_dmg);
        }
        [TestMethod]
        public void DamageReturnsCorrectValue()
        {
            var healer = new Healer("Michael");

            double actualAttack = healer.Attack();

            Assert.AreEqual(42, actualAttack);
        }

        [TestMethod]
        public void SpecialAbilityReturnsCorrectMessage()
        {
            var healer = new Healer("Michael");
            Assert.AreEqual("Healer casts area heal healing 20% of max health", healer.SpecialAbility());
        }
    }
}