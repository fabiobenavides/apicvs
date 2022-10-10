using BL.BL;
using NUnit.Framework;

namespace BL.Test
{
    [TestFixture]
    internal class ProccessorTest
    {
        Proccessor _proccessor;

        [SetUp]
        protected void SetUp()
        {
            _proccessor = new Proccessor();
        }

        [TestCase("\"Patient Name\",\"SSN\",\"Age\",\"Phone Number\",\"Status\"", "[Patient Name] [SSN] [Age] [Phone Number] [Status]")]
        [TestCase("\"Prescott, Zeke\",\"542-51-6641\",21,\"801-555-2134\",\"Opratory=2,PCP=1\"", "[Prescott, Zeke] [542-51-6641] [21] [801-555-2134] [Opratory=2,PCP=1]")]
        [TestCase("\"Goldstein, Bucky\",\"635-45-1254\",42,\"435-555-1541\",\"Opratory=1,PCP=1\"", "[Goldstein, Bucky] [635-45-1254] [42] [435-555-1541] [Opratory=1,PCP=1]")]
        [TestCase("\"Vox, Bono\",\"414-45-1475\",51,\"801-555-2100\",\"Opratory=3,PCP=2\"", "[Vox, Bono] [414-45-1475] [51] [801-555-2100] [Opratory=3,PCP=2]")]
        [TestCase("\"Goldstein, Bucky\",\"635-45-1254\",,\"435-555-1541\",\"Opratory=1,PCP=1\"", "[Goldstein, Bucky] [635-45-1254] [] [435-555-1541] [Opratory=1,PCP=1]")]
        [TestCase("\"Goldstein, Bucky\",\"635-45-1254\",,\"435-555-1541\",", "[Goldstein, Bucky] [635-45-1254] [] [435-555-1541] []")]
        public void input_cvs_should_return_expected_output(string inputCvs, string expectedResult)
        {
            //Arrange
            //Act
            var result = _proccessor.Process(inputCvs);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
