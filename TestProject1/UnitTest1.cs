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
        [TestMethod]
        public void GivenMailArray_WhenAnalyze_ShouldReturnValid()
        {
            string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com", "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            Validation validation = new Validation();
            string result = validation.ValidateMailIDArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (result == "valid")
                {
                    Assert.AreEqual("valid", result);
                }
                else
                {
                    Assert.AreEqual( "Invalid",result);
                }
            }


        }
    }
}