using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class RogueTests
    {
        [TestMethod]
        public void HasCorrectName()
        {
            var rogue = new Rogue("Adam");

            Assert.AreEqual("Adam", rogue.Name);
        }

        [TestMethod]
        public void HasCorrectBaseStats()
        {
            var rogue = new Rogue("Adam");

            Assert.AreEqual(65, rogue.Health);
            Assert.AreEqual(9, rogue.Strength);
            Assert.AreEqual(5, rogue.Intelligence);
            Assert.AreEqual(20, rogue.Agility);
            Assert.AreEqual(25, rogue.Crit_chance);
            Assert.AreEqual(150, rogue.Crit_dmg);
        }

        [TestMethod]
        public void DamageReturnsCorrectValue()
        {
            var rogue = new Rogue("Adam");

            double actualAttack = rogue.Attack();

            Assert.AreEqual(27, actualAttack);
        }

        [TestMethod]
        public void SpecialAbilityReturnsCorrectMessage()
        {
            var rogue = new Rogue("Adam");
            Assert.AreEqual("Rouge pickpockets enemies gaining from 10% to 25% of thier gold", rogue.SpecialAbility());
        }
    }
}