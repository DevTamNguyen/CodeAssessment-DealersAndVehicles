using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Threading.Tasks;

namespace DealersAndVehicles
{
    public class Main
    {        
        /// <summary>
        /// Main class to instaniate client API and start retrieving answer.
        /// </summary>
        /// <returns></returns>
        public static async Task<AnswerResponse> GetDealersAndVehichles() 
        {
            AnswerResponse answerResponse = new AnswerResponse();
            try
            {                
                //instantiate client api
                ClientApi clientApi = new ClientApi();                                

                //get answer from dataset api
                DataSetFactory dataSetFactory = new DataSetFactory();
                answerResponse = await dataSetFactory.GetAndPostAnswer();
                return answerResponse;
            }
            catch (Exception ex)
            {
                answerResponse.Success = false;
                answerResponse.Message = ex.Message;
                return answerResponse;
            }
        }
    }
}
