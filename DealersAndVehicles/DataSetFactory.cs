using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Threading.Tasks;

namespace DealersAndVehicles
{
    public class DataSetFactory
    {
        DataSetApi dataSetApi = new DataSetApi();
        VehiclesFactory vehiclesFactory = new VehiclesFactory();
        /// <summary>
        /// Dataset factory
        /// Gets dataset ID, calls vehicle factory, then dealer factory to obtain data necessary for answer
        /// </summary>
        /// <returns></returns>
        public async Task<AnswerResponse> GetAndPostAnswer()
        {
            AnswerResponse answerResponse = new AnswerResponse();
            Answer answer = new Answer();
            DatasetIdResponse datasetIdResponse = dataSetApi.GetDataSetId();
            //check datasetid response then get list of vehicles
            if (CheckDatasetIdResponse(datasetIdResponse))
            {
                string datasetId = datasetIdResponse.DatasetId;
                answer.Dealers = await vehiclesFactory.GetListOfVehicles(datasetId);
                answerResponse = dataSetApi.PostAnswer(datasetId, answer);
                return answerResponse;
            }
            else throw new ApiException(404, "DatasetIdResponse or Dataset ID not found.");            
        }

        /// <summary>
        /// Helper to check DatasetId Reponse attributes
        /// </summary>
        /// <param name="datasetIdResponse">DatasetIdResponse</param>
        /// <returns></returns>
        public static bool CheckDatasetIdResponse(DatasetIdResponse datasetIdResponse)
        {
            if (datasetIdResponse?.DatasetId == null || datasetIdResponse.DatasetId == "") return false;
            return true;          
        }
    }
}
