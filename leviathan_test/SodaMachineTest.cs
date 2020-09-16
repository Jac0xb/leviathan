using System;
using leviathan;
using leviathan.worldobjects;
using leviathan.worldobjects.items.edibles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leviathan_test
{
    [TestClass]
    public class SodaMachineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            leviathan.worldobjects.SodaMachine machine = new leviathan.worldobjects.SodaMachine();
            SodaCan can = new SodaCan();

            machine.Insert(can);

            Assert.Equals(1, machine.GetInventory().Count);
        }
    }
}
