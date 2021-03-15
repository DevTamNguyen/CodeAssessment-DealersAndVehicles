using DealersAndVehicles;
using IO.Swagger.Model;
using NUnit.Framework;
using System.Collections.Generic;


namespace DealersAndVechicles.Test
{
    public class DealersFactoryTester
    {
        DealersFactory dealersFactory = new DealersFactory();

        List<VehicleResponse> goodVehicleResponse = new List<VehicleResponse>()
        {
            new VehicleResponse {
                VehicleId = 265807453,
                Year = 2012,
                Make = "Nissan",
                Model = "Altima",
                DealerId = 1932752716
            }
        };

        List<DealersResponse> goodListDealers = new List<DealersResponse>()
        {
            new DealersResponse
            {
                DealerId = 1932752716,
                Name = "Doug's Doozies"
            }
        };

        List<VehicleResponse> badVehicleResponse = new List<VehicleResponse>()
        {
            null //no data
        };

        List<DealersResponse> badListDealers = new List<DealersResponse>()
        {
            null //no data
        };

        List<VehicleResponse> nullVehicleResponse = null;

        List<DealersResponse> nullListDealers = null;

        [Test]
        public void CheckVehicleResponseAndListOfDealers_Success()
        {
            Assert.IsTrue(dealersFactory.CheckVehicleResponseAndDealers(goodVehicleResponse, goodListDealers));
        }

        [Test]
        public void CheckVehicleResponseAndListOfDealers_NullVehicleResponse_Fail()
        {

            Assert.IsFalse(dealersFactory.CheckVehicleResponseAndDealers(nullVehicleResponse, goodListDealers));
        }

        [Test]
        public void CheckVehicleResponseAndListOfDealers_NullDealerList_Fail()
        {

            Assert.IsFalse(dealersFactory.CheckVehicleResponseAndDealers(goodVehicleResponse, nullListDealers));
        }

        [Test]
        public void CheckVehicleResponseAndListOfDealers_EmptyVehicleResponse_Fail()
        {

            Assert.IsFalse(dealersFactory.CheckVehicleResponseAndDealers(badVehicleResponse, goodListDealers));
        }

        [Test]
        public void CheckVehicleResponseAndListOfDealers_EmptyDealerList_Fail()
        {

            Assert.IsFalse(dealersFactory.CheckVehicleResponseAndDealers(goodVehicleResponse, badListDealers));
        }

        [Test]
        public void FormatAnswer_Success()
        {
            DealersFactory dealersFactory = new DealersFactory()
            {
                dealers = goodListDealers
            };

            List<DealerAnswer> dealerAnswers = dealersFactory.FormatAnswer(goodVehicleResponse);

            Assert.IsTrue(dealerAnswers.Count > 0);
        }
    }
}
