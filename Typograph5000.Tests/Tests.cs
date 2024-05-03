using NUnit.Framework;

namespace Typograph5000.Tests
{
    [TestFixture]
    public class Tests
    {
        private MainForm testForm = new MainForm();

        [SetUp]
        public void SetUp()
        {
            testForm.Settings[2] = true;
        }

        [Test]
        public void FixPunctuationsMarksTest()
        {
            var testString = "Hello , World!";
            Assert.True(MainForm.FixPunctuationsMarks(testString) == 
                "Hello, World!");
        }

        [Test]
        public void FixWhitespacesTest()
        {
            var testString = "Hello,  World!";
            Assert.True(MainForm.FixWhitespaces(testString) == 
                        "Hello, World!");
        }
        
        [Test]
        public void FixQuotesTest()
        {
            var testString = "\"Hello, World!\"";
            Assert.True(MainForm.FixQuotes(testString) == 
                        "«Hello, World!»");
        }
        
        [Test]
        public void FixHyphenTest()
        {
            var testString = "Hello - World!";
            Assert.True(MainForm.FixHyphen(testString) == 
                        "Hello-World!");
        }
        
        [Test]
        public void FixDashTest()
        {
            var testString = "Hello —World!";
            Assert.True(MainForm.FixDash(testString) == 
                        "Hello\u00a0— World!");
        }
        
        [Test]
        public void FixK()
        {
            var testString = "Не окей, а хорошо";
            Assert.True(MainForm.FixK(testString) == 
                        "Не k, а k");
        }
        
        [Test]
        public void FixSatanSocialNetwork()
        {
            var testString = "Скинь свою инсту инстаграмм";
            Assert.True(MainForm.FixSatanSocialNetwork(testString) == 
                        "Скинь свою сатанисткая соц-сеть сатанисткая соц-сеть");
        }
        
        [Test]
        public void FixSymbolsesTest()
        {
            var testString = "Hey.. Hello!!!!!!  World???????";
            Assert.True(MainForm.FixSymbols(testString) == 
                        "Hey... Hello!!!  World???");
        }
        
        [Test]
        public void TestFullSettings()
        {
            var testString = "Hello ,  World!! Instagram";
            Assert.True(testForm.Check(testString) == 
                        "Hello, World!!! сатанисткая соц-сеть");
        }
        
        [Test]
        public void TestHalfFullFullSettings()
        {
            testForm.Settings[2] = false;
            var testString = "Hello ,  World!! Instagram";
            Assert.True(testForm.Check(testString) == 
                        "Hello,  World!!! сатанисткая соц-сеть");
        }
    }
}