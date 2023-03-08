namespace NUnitTestExample.Test
{ 
    public class ResTest 
    {
        Res res;

        [SetUp]
        public void Setup()
        {
            res = new Res();
        }

        [Test]
        public void CanBeCancelledBy_CanBeCancelledByAdmin_ReturnTrue()
        { 
            Assert.IsTrue(res.CanBeCancelledBy(new User() { IsAdmin = true }));
        }

        [Test]
        public void CanBeCancelledBy_CanBeCancelling_ReturnTrue()
        {
            User user = new User();
            res.MadeBy = user;
            Assert.IsTrue(res.CanBeCancelledBy(user));
        }
    }
}