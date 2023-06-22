using User_Registration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Sanjana";
            Validation validation = new Validation();
            string result = validation.ValidateFirstName(name);
            Assert.AreEqual(result, "valid");
        }
    }
}