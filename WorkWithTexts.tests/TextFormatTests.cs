using System.Data;

namespace WorkWithTexts.tests
{
    [TestClass]
    public class TextFormatTests
    {
        [TestMethod]
        public void NameFormatPositiveTest()
        {
            string expected = "Vasara";
            string actual = TextFormat.NameFormat("vaSaRA");
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("+37063500697")]
        [DataRow("863500697")]
        [DataRow("37063500697")]
        [DataRow("0037063500697")]
        [DataRow("63500697")]
        [DataRow("863500697")]
        [DataRow("8 63500697")]
        [DataRow("8635 00697")]
        [DataRow("8-63500697")]
        [DataRow("8635-00697")]
        [DataRow("8(635)00697")]
        [DataRow("8(635) 00697")]
        [DataRow("8 (635) 00697")]
        [DataRow("63500697")]
        [DataRow("63500697")]
        [DataRow("635 00697")]
        [DataRow("63500697")]
        [DataRow("635-00697")]
        [DataRow("(635)00697")]
        [DataRow("(635) 00697")]
        [DataRow("(635) 00697")]
        [DataRow("37063500697")]
        [DataRow("370 63500697")]
        [DataRow("370 635 00697")]
        [DataRow("370-63500697")]
        [DataRow("370-635-00697")]
        [DataRow("370(635)00697")]
        [DataRow("370 (635) 00697")]
        [DataRow("370 (635) 00697")]
        [DataRow("+37063500697")]
        [DataRow("+370 63500697")]
        [DataRow("+370 635 00697")]
        [DataRow("+370-63500697")]
        [DataRow("+370-635-00697")]
        [DataRow("+370(635)00697")]
        [DataRow("+370 (635) 00697")]
        [DataRow("+370 (635) 00697")]
        [DataRow("0037063500697")]
        [DataRow("00370 63500697")]
        [DataRow("00370 635 00697")]
        [DataRow("00370-63500697")]
        [DataRow("00370-635-00697")]
        [DataRow("00370(635)00697")]
        [DataRow("00370 (635) 00697")]
        [DataRow("00370 (635) 00697")]
        public void PhoNoFormatPositiveTest(string input)
        {
            string expected = "63500697";
            string actual = TextFormat.PhoNoFormat(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EMailFormatPositiveTest()
        {
            Assert.AreEqual("bebras@hrmb.com", TextFormat.EMailFormat("BebrAS @HRMB.Com"));
        }


    }
}