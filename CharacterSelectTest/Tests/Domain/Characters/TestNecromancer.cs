using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class NecromancerTests
    {
        [TestMethod]
        public void HasCorrectName()
        {
            var necromancer = new Necromancer("Ainz Ooal Gown");

            Assert.AreEqual("Ainz Ooal Gown", necromancer.Name);
        }

        [TestMethod]
        public void HasCorrectBaseStats()
        {
            var necromancer = new Necromancer("Ainz Ooal Gown");

            Assert.AreEqual(30, necromancer.Health);
            Assert.AreEqual(3, necromancer.Strength);
            Assert.AreEqual(26, necromancer.Intelligence);
            Assert.AreEqual(4, necromancer.Agility);
            Assert.AreEqual(15, necromancer.Crit_chance);
            Assert.AreEqual(30, necromancer.Crit_dmg);
        }

        [TestMethod]
        public void DamageReturnsCorrectValue()
        {
            var necromancer = new Necromancer("Ainz Ooal Gown");

            double actualAttack = necromancer.Attack();

            Assert.AreEqual(9, actualAttack);
        }

        [TestMethod]
        public void SpecialAbilityReturnsCorrectMessage()
        {
            var necromancer = new Necromancer("Ainz Ooal Gown");
            Assert.AreEqual("Necromancer rises the dead army back to life , 3 skeletons appear infront of him", necromancer.SpecialAbility());
        }
    }
};