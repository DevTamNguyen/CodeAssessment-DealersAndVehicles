using DealersAndVehicles;
using IO.Swagger.Model;
using NUnit.Framework;
using System.Collections.Generic;

namespace DealersAndVechicles.Test
{
    public class VehicleFactoryTester
    {
        [Test]
        public void GetListOfVehicles_Success()
        {
            VehiclesFactory vehicleFactory = new VehiclesFactory();
            string datasetId = "j4LhZmDn2Ag";
            List<DealerAnswer> dealerAnswers = vehicleFactory.GetListOfVehicles(datasetId).Result;

            Assert.IsTrue(dealerAnswers.Count > 0);
        }
    }
}
