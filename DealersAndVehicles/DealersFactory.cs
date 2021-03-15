using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealersAndVehicles
{
    public class DealersFactory
    {
        DealersApi dealersApi = new DealersApi();
        List<DealerAnswer> dealerAnswers = new List<DealerAnswer>();                
        public List<DealersResponse> dealers = new List<DealersResponse>();

        /// <summary>
        /// Builds answer set to be submitted.
        /// Uses passed list of Vehicle Responses and List of dealers to build Dealer Answer
        /// </summary>
        /// <param name="vehicleResponses">List<VehicleResponse></param>
        /// <returns></returns>
        public List<DealerAnswer> FormatAnswer(List<VehicleResponse> vehicleResponses)
        {
            if (CheckVehicleResponseAndDealers(vehicleResponses, dealers))
            {
                dealerAnswers = dealers.Distinct()
                                    .Select(dealer =>
                                    new DealerAnswer
                                    {
                                        DealerId = dealer.DealerId,
                                        Name = dealer.Name,
                                        Vehicles = vehicleResponses.Where(vehicle => vehicle.DealerId == dealer.DealerId)
                                                              .Select(vehicle =>
                                                                    new VehicleAnswer
                                                                    {
                                                                        Make = vehicle.Make,
                                                                        Model = vehicle.Model,
                                                                        VehicleId = vehicle.VehicleId,
                                                                        Year = vehicle.Year
                                                                    })
                                                               .ToList()
                                    })
                                    .OrderBy(dealer => dealer.DealerId)
                                    .ToList();
            }
            else throw new ApiException(404, "No dealers or vehicles found.");

            return dealerAnswers;
        }

        /// <summary>
        /// helper function to check nulls/empty
        /// </summary>
        /// <param name="vehicleResponses">VehicleResponse</param>
        /// <param name="dealers">list</param>
        /// <returns></returns>
        public bool CheckVehicleResponseAndDealers(List<VehicleResponse> vehicleResponses, List<DealersResponse> dealers)
        {
            if (vehicleResponses != null && vehicleResponses.Count > 0 && dealers != null && dealers.Count > 0)
            {
                if (vehicleResponses.Contains(null)) return false;
                if (dealers.Contains(null)) return false;
                return true;
            }
            return false;
        }

        /// <summary>        
        /// Creates task to get dealer response containing dealer info
        /// Add data to list of dealers to build answer set
        /// </summary>
        /// <param name="datasetId">string</param>
        /// <param name="dealerId">int</param>        
        public void GetDealerResponseTask(string datasetId, int dealerId)
        {            
            var task = GetDealerAsync(datasetId, dealerId);
            var result = task.Result;
            dealers.Add(result);
        }

        /// <summary>
        /// Calls Dealer API to get Dealer Response
        /// </summary>
        /// <param name="datasetId">string</param>
        /// <param name="dealerId">int</param>
        /// <returns></returns>
        public async Task<DealersResponse> GetDealerAsync(string datasetId, int dealerId)
        {            
            DealersResponse dealersResponse = await dealersApi.GetDealerAsync(datasetId, dealerId);
            return dealersResponse;
        }
    }
}
