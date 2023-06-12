using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void PowerTest()
        {
            Robot testRobot = new Robot();
            testRobot.IsPowered = true;
            Assert.AreEqual(testRobot.IsPowered, true);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.IsPowered, false);
         }
         
    }
}
