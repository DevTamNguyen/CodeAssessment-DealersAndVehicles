using IO.Swagger.Model;
using NUnit.Framework;

namespace DealersAndVechicles.Test
{
    public class MainTests
    {
        [Test]
        public void GetAnswer_Success()
        {
            AnswerResponse answerResponse = DealersAndVehicles.Main.GetDealersAndVehichles().Result;            

            Assert.IsTrue(answerResponse.Success);
        }
    }
}