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
        [TestMethod]
        public void GivenLastName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Dhenge";
            Validation validation = new Validation();
            string result = validation.ValidateFirstName(name);
            Assert.AreEqual("valid", result);
        }
        [TestMethod]
        public void GivenMail_WhenAnalyze_ShouldReturnValid()
        {
            string mail = "abc.xyz@brizdgelabz.co.in";
            Validation validation = new Validation();
            string result = validation.ValidateMailID(mail);
            Assert.AreEqual("valid", result);   
        }
        [TestMethod]
        public void GivenMobileNumber_WhenAnalyze_ShouldReturnValid()
        {
            string mobile = "91 9135624879";
            Validation validation = new Validation();
            string result = validation.ValidateMobile(mobile);
            Assert.AreEqual("valid", result);
        }
        [TestMethod]
        public void GivenPassword_WhenAnalyze_ShouldReturnValid()
        {
            string pass = "Abcdef@2023";
            Validation validation = new Validation();
            string result = validation.ValidatePass(pass);
            Assert.AreEqual( "valid", result);
        }
    }
}