using DealersAndVehicles;
using IO.Swagger.Model;
using NUnit.Framework;

namespace DealersAndVechicles.Test
{
    public class DatasetFactoryTester
    {
        
        private DatasetIdResponse goodResponse = new DatasetIdResponse()
        {
            DatasetId = "abcdefghi"
        };

        private DatasetIdResponse emptyDatasetId = new DatasetIdResponse()
        {
            DatasetId = ""
        };

        private DatasetIdResponse emptyDatasetIdResponse = null;
        

        [Test]
        public void CheckGetListOfDealers_Success()
        {            
            Assert.IsTrue(DataSetFactory.CheckDatasetIdResponse(goodResponse));
        }

        [Test]
        public void CheckGetListOfDealers_EmptyDataSetId_Fail()
        {            
            Assert.IsFalse(DataSetFactory.CheckDatasetIdResponse(emptyDatasetId));
        }

        [Test]
        public void CheckGetListOfDealers_EmptyDatasetIdResponse_Fail()
        {
            Assert.IsFalse(DataSetFactory.CheckDatasetIdResponse(emptyDatasetIdResponse));
        }

        [Test]
        public void GetAnswer_Success()
        {
            DataSetFactory dataSetFactory = new DataSetFactory();
            AnswerResponse answerResponse = dataSetFactory.GetAndPostAnswer().Result;
            Assert.IsTrue(answerResponse.Success);
        }
    }
}
