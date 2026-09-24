using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class SkeletonTests
    {
        [TestMethod]
        public void HasCorrectName()
        {
            var skeleton = new Skeleton("Arc Lalatoya");

            Assert.AreEqual("Arc Lalatoya", skeleton.Name);
        }

        [TestMethod]
        public void HasCorrectBaseStats()
        {
            var skeleton = new Skeleton("Arc Lalatoya");

            Assert.AreEqual(20, skeleton.Health);
            Assert.AreEqual(6, skeleton.Strength);
            Assert.AreEqual(1, skeleton.Intelligence);
            Assert.AreEqual(4, skeleton.Agility);
            Assert.AreEqual(10, skeleton.Crit_chance);
            Assert.AreEqual(40, skeleton.Crit_dmg);
        }

        [TestMethod]
        public void DamageReturnsCorrectValue()
        {
            var skeleton = new Skeleton("Arc Lalatoya");

            double actualAttack = skeleton.Attack();

            Assert.AreEqual(18, actualAttack);
        }

        [TestMethod]
        public void SpecialAbilityReturnsCorrectMessage()
        {
            var skeleton = new Skeleton("Arc Lalatoya");
            Assert.AreEqual("Skeleton summons a single sword to fight with", skeleton.SpecialAbility());
        }
    }
}