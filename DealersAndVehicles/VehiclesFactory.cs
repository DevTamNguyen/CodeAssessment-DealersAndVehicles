using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DealersAndVehicles
{
    public class VehiclesFactory
    {
        VehiclesApi vehiclesApi = new VehiclesApi();
        DealersFactory dealersFactory = new DealersFactory();
        List<VehicleResponse> vehicles = new List<VehicleResponse>();

        /// <summary>
        /// Vehicle Factory
        /// Gets list of vehicles using passed dataset ID
        /// creates task factory and task for each vehicle ID, once tasks complete, format answer
        /// </summary>
        /// <param name="datasetId">string</param>
        /// <returns></returns>
        public async Task<List<DealerAnswer>> GetListOfVehicles(string datasetId)
        {            
            List<DealerAnswer> dealerAnswers = new List<DealerAnswer>();            
            VehicleIdsResponse vehicleIdResponse = vehiclesApi.GetIds(datasetId);            
            if (vehicleIdResponse?.VehicleIds != null)
            {
                var taskList = new List<Task>();
                SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
                //get data for each vehicle
                foreach (int vehicleId in vehicleIdResponse.VehicleIds)
                {
                    //create new task factory and add to task list for each vehicle returned in dataset
                    taskList.Add(
                    Task.Factory.StartNew(async () =>
                    {
                        return await GetVehicleResponseTask(datasetId, vehicleId);
                    })
                        .ContinueWith((t1) => dealersFactory.GetDealerResponseTask(datasetId, (int)t1.Result.Result.DealerId),
                        TaskScheduler.FromCurrentSynchronizationContext())
                    );
                }

                //wait for all tasks to finish before formatting final answer
                Task.WaitAll(taskList.ToArray());
                dealerAnswers = dealersFactory.FormatAnswer(vehicles);
            }
            else throw new ApiException(404, "No vehicle IDs found.");

            return dealerAnswers;            
        }

        /// <summary>
        /// Creates task to get vehicle response containing vehicle info including dealer id        
        /// Add data to list of vehicles to build answer set
        /// </summary>
        /// <param name="datasetId">string</param>
        /// <param name="iVehicleId">int</param>
        /// <returns>VehicleResponse</returns>
        private async Task<VehicleResponse> GetVehicleResponseTask(string datasetId, int iVehicleId)
        {           
            var task = GetVehicleAsync(datasetId, iVehicleId);
            var result = task.Result;
            vehicles.Add(result);
            return result;
        }

        /// <summary>
        /// Calls Vechicle API to get Vehicle Response
        /// </summary>
        /// <param name="datasetId">string</param>
        /// <param name="iVehicleId">int</param>
        /// <returns></returns>
        private async Task<VehicleResponse> GetVehicleAsync(string datasetId, int iVehicleId)
        {
            VehicleResponse vehicleResponse = await vehiclesApi.GetVehicleAsync(datasetId, iVehicleId);
            return vehicleResponse;
        }
    }
}
