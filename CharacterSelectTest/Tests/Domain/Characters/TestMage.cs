using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class MageTests
    {
        [TestMethod]
        public void HasCorrectName()
        {
            var mage = new Mage("Moonlight");

            Assert.AreEqual("Moonlight", mage.Name);
        }

        [TestMethod]
        public void HasCorrectBaseStats()
        {
            var mage = new Mage("Moonlight");

            Assert.AreEqual(80, mage.Health);
            Assert.AreEqual(4, mage.Strength);
            Assert.AreEqual(16, mage.Intelligence);
            Assert.AreEqual(10, mage.Agility);
            Assert.AreEqual(10, mage.Crit_chance);
            Assert.AreEqual(40, mage.Crit_dmg);
        }

        [TestMethod]
        public void DamageReturnsCorrectValue()
        {
            var mage = new Mage("Moonlight");

            double actualAttack = mage.Attack();

            Assert.AreEqual(48, actualAttack);
        }

        [TestMethod]
        public void SpecialAbilityReturnsCorrectMessage()
        {
            var mage = new Mage("Moonlight");
            Assert.AreEqual("Mage casts thunderbolt at enemies", mage.SpecialAbility());
        }
    }
}